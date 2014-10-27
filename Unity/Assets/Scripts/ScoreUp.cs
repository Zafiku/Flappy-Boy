using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour {

	private Text Texto;
	private Text TextoFinal;
	private Text menu;

	void Start(){
		Texto = GameObject.Find ("TextoNivel").GetComponent<Text>();
		TextoFinal = GameObject.Find ("TextoFinal").GetComponent<Text> ();
	}
	void OnTriggerEnter2D(Collider2D col){
		//Debug.Log (GameControl.score);
		GameControl.score = GameControl.score + 1;
		Texto.text = "Level" + GameControl.score.ToString ();
		TextoFinal.text = Texto.text;
	}
}