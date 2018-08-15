using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAngelController : MonoBehaviour {

	//Angelの移動速度
	private float speed = 0.2f;

	//消滅位置
	private float deadLine = -50;

	//オーディオコンポーネントを入れる
	public AudioSource sound1;
	//public AudioSource sound2;

	//消滅
	public bool dead = false;


	// Use this for initialization
	void Start () {

		//オーディオコンポーネントを取得
//		AudioSource[] audioSources = GetComponents<AudioSource>();
//		sound1 = audioSources [0];
//		sound2 = audioSources [2];
		
	}
	
	// Update is called once per frame
	void Update () {
		//Angelを移動させる
		transform.Translate (0,0,this.speed);

		//画面外に出たら破棄する
		if(transform.position.x < this.deadLine){

			//deadをtrueにする
			this.dead = true;
			//BGM鳴らす
			//sound2.PlayOneShot(sound2.clip);
			Destroy (gameObject);

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
