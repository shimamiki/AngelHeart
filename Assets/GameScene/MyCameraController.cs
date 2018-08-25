using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {

	//Angelのオブジェクト
	public GameObject angel;
	//AngelControllerを入れるコンポーネント
	private AngelController angelController;


	//Angelとカメラのきょり　
	private float difference;







	// Use this for initialization
	void Start () {
		//Angelのオブジェクトを取得
		this.angel = GameObject.Find ("Angel");
		//AngelControllerを取得
		this.angelController =angel.GetComponent<AngelController>();


		//Angelとカメラの位置（z座標）の差を求める
		this.difference = angel.transform.position.z - this.transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {
		//Angelの位置に合わせてカメラの移動
		this.transform.position = new Vector3(0,this.transform.position.y,this.angel.transform.position.z - difference);


		if (this.angelController.isEnd) {
			//カメラワーク
			this.transform.position = new Vector3 (5,this.angel.transform.position.y - 2,this.angel.transform.position.z + 10);

			var aim = this.angel.transform.position - this.transform.position;
			var look = Quaternion.LookRotation(aim);
			this.transform.localRotation = look;
			}
		
	}
}
