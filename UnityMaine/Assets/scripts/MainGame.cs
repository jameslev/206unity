using UnityEngine;
using System.Collections;

public class MainGame : MonoBehaviour {
	int count;
	public bool eventhappening,eventinterface;
	public string txtfieldOne = "HELLO";
	public string[] eventsudo = {"Environmental Event!", "Poltical Event!", "National Event!"};
	public string eventis;
	// Use this for initialization
	void Start () {
		count = 0;

		Screen.SetResolution (640, 480, false, 60);
		GameObject.Find ("startBG").transform.position = new Vector3 (13,3.5f,-2);
		//GameObject.Find ("startbutton").transform.position = new Vector3 (13,3.5f,-5);
		GameObject.Find ("newgamebutton").transform.position = new Vector3 (13,2,-5);
		Time.timeScale = 0;
		InvokeRepeating ("eventCheck",5,5);
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		if (eventinterface) {

			GameObject.Find ("interfaceBG").transform.position = new Vector3 (13.5f, 3.5f, -3);
			GameObject.Find ("interfaceBG").transform.localScale = new Vector3(0.5f,0.5f,1);
			float frameX = GameObject.Find ("interfaceBG").transform.position.x;
			float frameY = GameObject.Find ("interfaceBG").transform.position.y;
			GameObject.Find ("okbutton").GetComponent<okayButtonQuality>().eventint = true;

			GUI.Label(new Rect (frameX+210,frameY+150, 300, 20), "Event Alert!");
			GUI.Label(new Rect (frameX+210,frameY+180, 300, 20), eventis);

			
		} else {
			GameObject.Find ("interfaceBG").transform.position = new Vector3 (-11.5f, 15.5f, -1);

			GameObject.Find ("okbutton").GetComponent<okayButtonQuality>().eventint = false;
		}
	}

	void eventCheck(){

		eventhappening = true;
		if(eventhappening){
			Debug.Log ("IT REPEATS!"+count);
			count++;
			eventinterface=true;
			eventis = eventsudo[Random.Range(0,2)];
			CancelInvoke("eventCheck");
		}


	}
}
