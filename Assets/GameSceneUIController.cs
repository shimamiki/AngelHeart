using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneUIController : MonoBehaviour {

	//Angelオブジェクトを取得
	private GameObject angel;
		//AngelControllerを入れるコンポーネント
	private AngelController angelController;

	// Use this for initialization
	void Start () {
		//Angelを取得
		this.angel = GameObject.Find("Angel");
		//AngelControllerを取得
		this.angelController = angel.GetComponent<AngelController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.angelController.isEnd && Input.GetMouseButtonDown (0)) {
			//クリックされたらシーンをロードする
			SceneManager.LoadScene ("Result");
		}
		
	}
}
