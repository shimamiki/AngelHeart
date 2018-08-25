using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour {

	//AngelSを入れる
	public GameObject angelS ;
	//AngelSControllerを入れる
	private AngelSController angelSController;

	//Angelを入れる
	public GameObject angel;
	//AngelControllerを入れる
	//private AngelController angelController;

	//sliderを入れる
	Slider slider;
	//最初は0点
	public float ScoreResult = 0f;

	//スコアを表示するテキスト
	private GameObject scoreText;


	// Use this for initialization
	void Start () {

		//sliderを取得
		slider = GameObject.Find("Slider").GetComponent<Slider>();

		//AngelSのオブジェクトを取得
		this.angelS =GameObject.Find("AngelS");
		//AngelSControllerを取得
		this.angelSController = angelS.GetComponent<AngelSController>(); 

		//AngelSのオブジェクトを取得
		this.angel =GameObject.Find("Angel");
		//AngelSControllerを取得
		//this.angelController = angel.GetComponent<AngelController>(); 

		//ScoreTextのオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");


		
	}

	//scoreを取得
	int Score = AngelController.score;

	//float timeCount = 3;

	// Update is called once per frame
	void Update () {
		//Debug.Log (Score);

		//AngelのLandingがtrueなら伸び始める
		if(angelSController.Landing){
			
				if(ScoreResult<((float)Score/10)){
					ScoreResult += 0.1f;
				}
				slider.value = ScoreResult;
				//獲得したスコアを表示
			this.scoreText.GetComponent<Text>().text =(ScoreResult*10).ToString("0")+ "/10" ;
		
		}


	}
}
