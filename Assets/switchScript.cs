using UnityEngine;
using System.Collections;

public class switchScript : MonoBehaviour {

	static int sceneNumber = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			sceneNumber += 1;
			if (sceneNumber > 2) {
				sceneNumber = 0;
			}
			Debug.Log (sceneNumber);
			Application.LoadLevel ("scene0"+(sceneNumber+1).ToString());
		}
	}
}
