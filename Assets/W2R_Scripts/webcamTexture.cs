using UnityEngine;
using System.Collections;

public class webcamTexture : MonoBehaviour {

	// Use this for initialization
	void Start() {
		WebCamDevice[] devices = WebCamTexture.devices;



		// devices auflisten
		int i = 0;
		while (i < devices.Length) {
			Debug.Log(devices[i].name);
			i++;
		}

		// device wählen und abspielen
		WebCamTexture webcamTexture = new WebCamTexture();

		if (devices.Length > 0) {
			Debug.Log("Taking DEVICE: " + devices[0].name);
			webcamTexture.deviceName = devices[0].name;

			renderer.material.mainTexture = webcamTexture;
			webcamTexture.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
