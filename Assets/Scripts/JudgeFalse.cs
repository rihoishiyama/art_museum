using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeFalse : MonoBehaviour {

	public GameObject hatenan;
	public GameObject batsun;
	public Judgement judgement;

	// Use this for initialization
	void Start () {
	}
	
	void Update () {
		Debug.Log ("ほげ");
		if (judgement.resultValue == "ButtonFalse") {
			hatenan.SetActive (false);
			batsun.SetActive (true);

		}
	}
		
}
