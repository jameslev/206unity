using UnityEngine;
using System.Collections;

public class pausedButtonQuality : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){

		Time.timeScale = 1.0f;
		GameObject.Find ("playpausebutton").transform.position = new Vector3 (-14,-5,0);
		GameObject.Find("pausedBG").transform.position = new Vector3 (-14,-5,0);
	}
}
