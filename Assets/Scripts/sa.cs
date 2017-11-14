using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sa : MonoBehaviour {
	public GameObject hatena1;
	public GameObject batsu;
	public Judgement judgement;

	public void OnClick (int number){

		switch (number) {
			case 0:
				Debug.Log ("戻る");
				judgement.resultValue = null;
				hatena1.SetActive (true);
				batsu.SetActive (false);
				break;
			default:
				break;
		}
	}
}