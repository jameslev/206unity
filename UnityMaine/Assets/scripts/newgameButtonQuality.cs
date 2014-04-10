using UnityEngine;
using System.Collections;

public class newgameButtonQuality : MonoBehaviour {

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
		//GameObject.Find ("startbutton").transform.position += new Vector3 (20,20,0);
		transform.position += new Vector3 (20,20,0);
		GameObject.Find ("choosepartyBG").transform.position = new Vector3 (13.5f,3,-1);
		GameObject.Find ("choosepartyBG").GetComponent<choosepartySequence> ().stepOne = true;


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
