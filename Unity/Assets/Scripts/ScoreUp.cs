using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour {

	private Text texto;

	void Start(){
		//texto = GameObject.Find ("TextoNivel").GetComponent
	}
	void OnTriggerEnter2D(Collider2D col){
		Debug.Log (GameControl.score);
		GameControl.score = GameControl.score + 1;
	}
}