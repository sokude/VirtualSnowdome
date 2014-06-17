using UnityEngine;
using System.Collections;

public class webcamCtrl : MonoBehaviour {
	WebCamTexture webcamTexture = null;
	public Transform cameraScreen;
	// Use this for initialization
	void Start () {
		WebCamDevice[] devices = WebCamTexture.devices;
		if (devices.Length > 0) {
			webcamTexture = new WebCamTexture (320, 240, 12);
			cameraScreen.renderer.material.mainTexture = webcamTexture;
			webcamTexture.Play ();
		} else {
			Debug.LogError ("no camera");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDestroy()
	{
		if (webcamTexture != null) {
			webcamTexture.Stop ();
		}
	}
}
