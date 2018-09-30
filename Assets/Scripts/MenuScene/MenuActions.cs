using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour {

	public Button btnJogar, btnInstrucoes;

	// Use this for initialization
	void Start () {
		btnJogar.onClick.AddListener(OnJogarClick);
		btnInstrucoes.onClick.AddListener(OnInstrucoesClick);
	}
	
	//Starts the game - Generate random animal word and Set value
	void OnJogarClick() {
		SceneManager.LoadScene("MainScene");
	}

	void OnInstrucoesClick() {
		Debug.Log("TODO Instrucoes");
	}
}
