using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAngelController : MonoBehaviour {

	//Angelの移動速度
	private float speed = 0.2f;

	//停止位置
	private float deadLine = -50;

	//オーディオコンポーネントを入れる
	public AudioSource sound1;

	//Angelのオブジェクト
	public GameObject bgmController;

	private TBGMController tbgmController;

	// Use this for initialization
	void Start () {

	
		//Angelのオブジェクトを取得
		this.bgmController = GameObject.Find ("BGMController");
		//AngelControllerを取得
		this.tbgmController =bgmController.GetComponent<TBGMController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		//Angelを移動させる
		transform.Translate (0,0,this.speed);

		//画面外に出たらストップしてｂｇｍを流す
		if(transform.position.x < this.deadLine){

			Destroy (gameObject);

			tbgmController.playbgm();


		}
		
	}
		
	//トリガーモードでほかのオブジェクトと接触した場合の処理
	void OnTriggerEnter(Collider other){
		//ハートに衝突した場合
		if (other.gameObject.tag == "HeartTag") {
			//ハートを破棄
			Destroy (other.gameObject);
			//SE鳴らす
			sound1.PlayOneShot(sound1.clip);
		}
	}
}
