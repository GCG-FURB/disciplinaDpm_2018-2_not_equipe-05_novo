using Assets.Scripts.MainScene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Inicio()
    {
        StaticProperties.Instance.ClearAnimaisJogados();
        SceneManager.LoadScene("MenuScene");
    }

    public void Continuar()
    {
        SceneManager.LoadScene("MainScene");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
