using UnityEngine;
using System.Collections;

public class startButtonQuality : MonoBehaviour {

	public Color colorOver = new Color(1f,0.88f,0.55f); 
	
	private Color originalColor;
	// Use this for initialization
	void Start () {
		originalColor = gameObject.renderer.material.color; 
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseUp(){

		GameObject.Find ("startBG").transform.position += new Vector3(20,20,0);
		GameObject.Find ("newgamebutton").transform.position += new Vector3(20,20,0);
		transform.position += new Vector3 (20,20,0);
		Time.timeScale = 1.0f;


	}

	void OnMouseEnter()     
		
	{
		
		gameObject.renderer.material.color= colorOver;
		
	}   
	
	
	
	void OnMouseExit()
		
	{
		
		gameObject.renderer.material.color= originalColor;
		
	}


}
