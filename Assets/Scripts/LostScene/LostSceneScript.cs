using Assets.Scripts.MainScene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LostSceneScript : MonoBehaviour {

    public Text Mensagem;

	// Use this for initialization
	void Start () {
        Mensagem.text += "\r\nNome do animal: " + StaticProperties.Instance.CurrentAnimal.Nome;
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
