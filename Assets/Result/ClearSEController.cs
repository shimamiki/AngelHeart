using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearSEController : MonoBehaviour {

	//AudioSource入れる
	private AudioSource audiosource;
	//AngelSを入れる
	//public GameObject angelS ;
	//AngelSControllerを入れる
	//private AngelSController angelSController;

	//SE流すまでの時間
	//float SEstart = 3;


	// Use this for initialization
	void Start () {

		//AudioSourceを取得
		audiosource = gameObject.GetComponent<AudioSource>();
		//AngelSのオブジェクトを取得
		//this.angelS =GameObject.Find("AngelS");
		//AngelSControllerを取得
		//this.angelSController = angelS.GetComponent<AngelSController>(); 
	}



	// Update is called once per frame
	void Update () {

		//if (angelSController.canvasActive){

			//SEstart -= Time.deltaTime;

			//if (SEstart <= 0) {
				//audiosource.Play ();

			//}
		//} 

	}

	public void playClearSE(){
		audiosource.Play();
	}
}
