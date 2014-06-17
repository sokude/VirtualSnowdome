using UnityEngine;
using System.Collections;

public class mainCtrlScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Physics.gravity = new Vector3(Input.acceleration.x,Input.acceleration.y,Input.acceleration.z * -1);
	}
}
