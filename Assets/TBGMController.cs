using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TBGMController : MonoBehaviour {

	//Angelのオブジェクト
	public GameObject angel;
	//AngelControllerを入れるコンポーネント
	private TAngelController angelController;

	//オーディオを入れる
	private AudioSource audioSource;


	// Use this for initialization
	void Start () {

		//Angelのオブジェクトを取得
		this.angel = GameObject.Find ("Angel");
		//AngelControllerを取得
		this.angelController =angel.GetComponent<TAngelController>();
		//audioSourceにコンポーネント入れる
		audioSource = gameObject.GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (this.angelController.dead) {

			audioSource.Play();
			
		}
		
	}
}
