using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TBGMController : MonoBehaviour {


	//オーディオを入れる
	private AudioSource audioSource;


	// Use this for initialization
	void Start () {
		//audioSourceにコンポーネント入れる
		audioSource = gameObject.GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void playbgm (){
		audioSource.Play ();
	}
}
