using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class CoringaController : MonoBehaviour, ITrackableEventHandler
{
    public Text TextoDica;
    private TrackableBehaviour mTrackableBehaviour;

    // Use this for initialization
    void Start () {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            var gameController = (GameController)FindObjectOfType(typeof(GameController));
            string texto = "1. " + gameController.CurrentAnimal.PrimeiraDica + "\r\n" + "2. " + gameController.CurrentAnimal.SegundaDica + "\r\n" + "3. " + gameController.CurrentAnimal.TerceiraDica;

            TextoDica.text = texto;
            Debug.Log(texto);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
