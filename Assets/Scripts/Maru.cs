using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Maru : MonoBehaviour {

	public GameObject maru;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		StartCoroutine ("DeleteCircle"); 
	}

	private IEnumerator DeleteCircle() {  
		yield return new WaitForSeconds (1.5f);
		Debug.Log ("消えた！！！！！！！！！！！！！！！！！！！！！！！！！！！！１");
		maru.SetActive (false);
	}  
}