using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour {


	//上にあがるスピード
	private float speed = 12.0f;
	//壁と当たったか
	private bool trigger = false;

	// Use this for initialization
	void Start () {
		//this.speed = Random.Range (0.05f, 0.1f);	

		//回転を開始する角度を設定
		this.transform.Rotate (0,0,Random.Range(0,360));
	}
	
	// Update is called once per frame
	void Update () {
		//回転
		this.transform.Rotate(0,0,3);

		if (trigger) {
			//上に動く
			this.transform.Translate (0, 0, this.speed*Time.deltaTime);
		}
		
	}

	//トリガーモードで他のオブジェクトと接触した場合の処理（追加）
	void OnTriggerEnter(Collider other) {



		//壁と衝突した場合
		if (other.gameObject.tag == "WallTag") {

			this.trigger = true;
		}                
	}
}
