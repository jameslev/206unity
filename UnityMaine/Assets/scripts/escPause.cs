using UnityEngine;
using System.Collections;

public class escPause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Escape)) {
			Time.timeScale = 0.0f;
			GameObject.Find("pausedBG").transform.position= new Vector3(11,2,0);
			GameObject.Find ("playpausebutton").transform.position = new Vector3 (11,2,-2);
				}
	
	}
}
