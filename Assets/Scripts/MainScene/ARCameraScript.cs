using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARCameraScript : MonoBehaviour {

    public string deviceName;
    WebCamTexture wct;

    // Use this for initialization
    void Start () {
        //DontDestroyOnLoad(this.gameObject);
        WebCamDevice[] devices = WebCamTexture.devices;
        deviceName = devices[0].name;
        wct = new WebCamTexture(deviceName, 400, 300, 12);
        GetComponent<Renderer>().material.mainTexture = wct;
        wct.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
