using Assets.Scripts.MainScene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPhaseController : MonoBehaviour {
    
    public Text TextoFinal;
    public string Frase;

	// Use this for initialization
	void Start () {
        Frase += "\r\n" + StaticProperties.Instance.CurrentAnimal.Nome;
        TextoFinal.text = Frase;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
