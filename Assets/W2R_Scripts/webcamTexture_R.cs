using UnityEngine;
using System.Collections;

public class webcamTexture_R : MonoBehaviour {
	public static string rightCamName = "Enter Cam name here";



	// Use this for initialization
	void Start() {
		WebCamDevice[] devices = WebCamTexture.devices;



//		// devices auflisten
//		int i = 0;
//		while (i < devices.Length) {
//			Debug.Log(devices[i].name);
//			i++;
//		}

		WebCamTexture webcamTexture_R = new WebCamTexture();

//		if (devices.Length > 0) {
//			Debug.Log("Taking DEVICE: " + devices[1].name);
//			webcamTexture_R.deviceName = devices[1].name;
//
//			renderer.material.mainTexture = webcamTexture_R;
//			webcamTexture_R.Play();
//		}
		webcamTexture_R.deviceName = rightCamName;
		renderer.material.mainTexture = webcamTexture_R;
		webcamTexture_R.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}