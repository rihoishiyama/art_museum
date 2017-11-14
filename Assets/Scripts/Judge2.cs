using UnityEngine;
using System.Collections;
using System;

public class Judge2 : MonoBehaviour {

	public GameObject hatena;
	public GameObject seikai;
	public Judgement judgement;


	// Use this for initialization
	void Start () {
	}


	void Update () {
		if (judgement.resultValue == "ButtonCollect") {
			Debug.Log ("正解");
			hatena.SetActive (false);
			seikai.SetActive (true);

		}
	}


}