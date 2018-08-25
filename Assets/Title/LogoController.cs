using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoController : MonoBehaviour {
	//Angelのオブジェクト
	private GameObject angel;
	//Angelとの距離
	private float difference;



	// Use this for initialization
	void Start () {
		//Angelのオブジェクトを取得
		this.angel = GameObject.Find ("Angel");
		//AngleとLogoの位置（X座標）の差
		this.difference = angel.transform.position.x - this.transform.position.x;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (this.transform.position.x > 0) {
			//Angelの位置に合わせて移動する
			this.transform.position = new Vector3 (this.angel.transform.position.x - difference,this.transform.position.y,0);
		} 
		
	}
}
	