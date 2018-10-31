using Assets.Scripts.MainScene;
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
            string texto = "1. " + StaticProperties.Instance.CurrentAnimal.PrimeiraDica + "\r\n" + "2. " + StaticProperties.Instance.CurrentAnimal.SegundaDica + "\r\n" + "3. " + StaticProperties.Instance.CurrentAnimal.TerceiraDica;

            TextoDica.text = texto;
            Debug.Log(texto);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
