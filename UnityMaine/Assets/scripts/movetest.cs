using UnityEngine;
using System.Collections;

public class movetest : MonoBehaviour {
	public bool thingy;
	// Use this for initialization
	void Start () {
		thingy = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0.1f,0,0) * Time.deltaTime;

		if(thingy){
			Debug.Log("THINGY WORKED");
		}
	}
}
