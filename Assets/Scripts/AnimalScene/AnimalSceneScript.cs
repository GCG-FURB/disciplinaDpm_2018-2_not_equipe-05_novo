using Assets.Scripts.MainScene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Continuar()
    {
        if (StaticProperties.Instance.AnimaisJogados.Count < StaticProperties.Instance.Animais.Count)
            SceneManager.LoadScene("MainScene");
        else
            SceneManager.LoadScene("FinalScene");
    }
}
