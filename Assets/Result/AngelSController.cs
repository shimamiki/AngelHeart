using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelSController : MonoBehaviour {

	//オーディオコンポーネントを入れる
	private AudioSource audioSource;
	//着地したかどうか
	public bool Landing = false ;
	//canvasを入れる
	GameObject canvas ;
	//canvasを入れる
	GameObject canvas2 ;

	private GameObject clearSE;
	private ClearSEController clearSEController;



	// Use this for initialization
	void Start () {

		//AudioSourceを取得
		audioSource = gameObject.GetComponent<AudioSource>();

		//canvasを取得
		canvas = GameObject.Find("Canvas");
		//canvasを非表示
		canvas.gameObject.SetActive (false);

		//canvasを取得
		canvas2 = GameObject.Find("Canvas2");
		//canvasを非表示
		canvas2.gameObject.SetActive (false);

		this.clearSE = GameObject.Find ("ClearSEController");
		this.clearSEController = clearSE.GetComponent<ClearSEController> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//衝突
	void OnCollisionEnter(Collision other){
		//bgmを止める
		audioSource.Stop();

		//Landingをtrueにする
		Landing = true;

		//3秒おくらす
		Invoke ("Canvas", 3);

		Invoke ("SE", 5);

		Invoke ("Canvas2", 8);




		}

	//canvasを表示
	private void Canvas(){
		canvas.gameObject.SetActive (true);
	}

	//canvasを表示
	private void Canvas2(){
		canvas2.gameObject.SetActive (true);
	}

	//clearSEならす
	private void SE() {
		clearSEController.playClearSE();
	}


}
