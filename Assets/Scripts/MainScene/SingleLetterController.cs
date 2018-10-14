using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SingleLetterController : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;
	public char letter;

	// Use this for initialization
	void Start () 
	{
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
            Debug.Log("Letter " + letter + " Detected");
            var gameController = (GameController)FindObjectOfType(typeof(GameController));
            gameController.UpdatePalavra(letter);
            Debug.Log("Atualizou a palavra");
        }
    }
}
