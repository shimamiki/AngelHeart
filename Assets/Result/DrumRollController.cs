using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumRollController : MonoBehaviour {

	//オーディオコンポーネントを入れる
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {

		//オーディオコンポーネント取得
		audioSource = gameObject.GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){

		audioSource.Play();
	
	}
}
