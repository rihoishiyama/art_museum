using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgement : MonoBehaviour {

	public string resultValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject obj = getClickObject ();
		if (obj != null) {
			Debug.Log ("clickされたよ");
			Debug.Log (obj.name);
			Debug.Log ("------------");
			resultValue = obj.name;
		} else {
			resultValue = null;
		}
	}

	public GameObject getClickObject() {
		GameObject result = null;
		// 左クリックされた場所のオブジェクトを取得
		if(Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			if (Physics.Raycast(ray, out hit)){
				result = hit.collider.gameObject;
				Debug.Log(result);
			}
		}
		return result;
	}
}
