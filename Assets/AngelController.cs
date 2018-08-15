using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AngelController : MonoBehaviour {

	//Angelを移動させるコンポーネント
	private Rigidbody myRigidbody;
	//前進する為の力
	private float forwardForce = 800.0f;
	//左右に移動する為の力
	private float turnForce = 500.0f;
	//左右の移動できる範囲
	private float movableRange = 3.4f;

	//動きを減速させる係数
	private float coefficient = 0.95f;
	//ゲーム終了の判定
	public bool isEnd = false;

	//スコアを表示するテキスト
	private GameObject scoreText;
	//得点
	private int score = 0;

	//左ボタン押下の判定
	private bool isLButtonDown = false;
	//右ボタン押下の判定
	private bool isRButtonDown = false;

	//オーディオコンポーネントを入れる
	private AudioSource audioSource;

	//ゲーム終了時に表示するテキスト
	private GameObject stateText;



	// Use this for initialization
	void Start () {



		//Rigidbodyコンポーネントを取得
		this.myRigidbody = GetComponent<Rigidbody>();

		//シーン中のscoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");

		//オーディオコンポーネントを取得
		audioSource = gameObject.GetComponent<AudioSource>();
		//stateTextオブジェクトを取得
		this.stateText = GameObject.Find("GameResultText");
	}
	
	// Update is called once per frame
	void Update () {

		//ゲーム終了ならAngelの動きを減衰する
		if (this.isEnd) {
			//this.forwardForce *= this.coefficient;
			this.turnForce *= this.coefficient;
		}


		//Angelに前方向の力をくわえる
		this.myRigidbody.AddForce (this.transform.forward * this.forwardForce);

		//Angelを矢印キーに応じて移動させる
		if ((Input.GetKey (KeyCode.LeftArrow) || this.isLButtonDown) && -this.movableRange < this.transform.position.x) {
			//左に移動
			this.myRigidbody.AddForce (-this.turnForce, 0, 0);
		} else if ((Input.GetKey (KeyCode.RightArrow) || this.isRButtonDown) && this.movableRange > this.transform.position.x) {
			//右に移動
			this.myRigidbody.AddForce (this.turnForce, 0, 0);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			//後ろに移動
			this.forwardForce *= this.coefficient;
		}else if (Input.GetKey (KeyCode.UpArrow)) {
			//前に移動
			this.forwardForce /= this.coefficient;
		}
	}

	//トリガーモードでほかのオブジェクトと接触した場合の処理
	void OnTriggerEnter(Collider other){

		//ゴールに到達した場合
		if(other.gameObject.tag == "GoalTag"){
			this.isEnd = true;
			//stateTextにゴール！を表示
			this.stateText.GetComponent<Text>().text = "GOAL!!";
		}

		//ハートに衝突した場合
		if(other.gameObject.tag == "HeartTag"){
			//スコアを加算
			this.score += 1;

			//獲得したスコアを表示
			this.scoreText.GetComponent<Text>().text = "×"+ this.score;

			//パーティクルを再生する
			GetComponent<ParticleSystem>().Play();
			//ハートを破棄
			Destroy (other.gameObject);
			//SE鳴らす
			audioSource.Play();
		}

	}



	//左ボタンを押し続けた場合の処理
	public void GetMyLeftButtonDown(){
		this.isLButtonDown = true;
	}
	//左ボタンを離した場合の処理
	public void GetMyLeftButtonUp(){
		this.isLButtonDown = false;
	}
	//右ボタンを押し続けた場合の処理
	public void GetMyRightButtonDown(){
		this.isRButtonDown = true;
	}
	//右ボタンを離した場合の処理
	public void GetMyRightButtonUp(){
		this.isRButtonDown = false;
	}
}
