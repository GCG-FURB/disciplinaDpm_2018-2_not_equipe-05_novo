using Assets.Scripts.MainScene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Inicio()
    {
        StaticProperties.Instance.ClearAnimaisJogados();
        SceneManager.LoadScene("MenuScene");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
