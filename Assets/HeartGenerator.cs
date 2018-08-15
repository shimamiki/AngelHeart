using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGenerator : MonoBehaviour {

	//heartPrefabを入れる
	public GameObject heartPrefab;

	//スタート地点
	private int startPos = -160;
	//ゴール地点
	private int goalPos = 120;
	//アイテムを出すX方向の範囲
	private float posRange = 3.4f;



	// Use this for initialization
	void Start () {
		//一定の距離ごとにアイテムを生成
		for (int i = startPos; i< goalPos ; i+=15){
			//レーン毎に生成
			for (int j = -1; j<=1; j++){
				int offsetZ = Random.Range (-5, 6);
				GameObject heart = Instantiate (heartPrefab) as GameObject;
				heart.transform.position = new Vector3 (posRange * j, heart.transform.position.y, i + offsetZ);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}




}

