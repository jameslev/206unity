using UnityEngine;
using System.Collections;



public class pauseButtonQuality : MonoBehaviour {


	
	public Color colorOver = new Color(1f,0.88f,0.55f); 
	
	public Color colorPushed  = new Color(0.66f,0.66f,0.48f);

	private Color originalColor;
	// Use this for initialization
	void Start () {
		originalColor = gameObject.renderer.material.color;  
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){

		Time.timeScale = 0.0f;

	}

	void OnMouseEnter(){
		gameObject.renderer.material.color= colorOver;

	}

	void OnMouseExit(){
		gameObject.renderer.material.color= originalColor;
	}
}
