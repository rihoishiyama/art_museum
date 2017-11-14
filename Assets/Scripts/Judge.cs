using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Judge : MonoBehaviour {
	public GameObject parent;
	public GameObject parent2;


	public void OnClick (int number){

		switch (number) {

		case 0:
			Debug.Log ("不正解");
			parent.SetActive (false);
			parent2.SetActive (true);
			break;
		case 1:
			Debug.Log ("正解");
			parent.SetActive (false);
			parent2.SetActive (true);
			break;
		case 2:
			Debug.Log ("不正解");
			parent.SetActive (false);
			parent2.SetActive (true);
			break;
		default:
			break;
		}

	}


//	void Update(){
//		if (Input.GetMouseButtonDown (0)) {
//			JudgeAnswer ();
//		} else {
//		}
//	}
//
//	//選択したボタンのテキストラベルと正解のテキストを比較して正誤を判定
//	public void JudgeAnswer(){
//		//正解のデータをテキストでセットする
//		string answerText = "(2) 黄色";
//		//選択したボタンのテキストラベルを取得する
//		Text selectedBtn = this.GetComponentInChildren<Text> ();
//
//		if (selectedBtn.text == answerText) {
//			Debug.Log("正解");
//		} else {
//			Debug.Log("不正解");
//		}
//	}
}
