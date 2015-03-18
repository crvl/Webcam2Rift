using UnityEngine;
using System.Collections;

public class webcamTexture_L : MonoBehaviour {
	public static string leftCamName = "Enter Cam Name here";



	// Use this for initialization
	void Start() {
		WebCamDevice[] devices = WebCamTexture.devices;
		
		
		
				// devices auflisten
				int i = 0;
				while (i < devices.Length) {
					Debug.Log(devices[i].name);
					i++;
				}

		WebCamTexture webcamTexture_L = new WebCamTexture();
		
//		if (devices.Length > 0) {
//			Debug.Log("Taking DEVICE: " + devices[0].name);
//			webcamTexture_L.deviceName = devices[0].name;
//			
//			renderer.material.mainTexture = webcamTexture_L;
//			webcamTexture_L.Play();
//		}
		webcamTexture_L.deviceName = leftCamName;
		renderer.material.mainTexture = webcamTexture_L;
		webcamTexture_L.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}