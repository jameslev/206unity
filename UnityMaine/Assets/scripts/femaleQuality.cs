using UnityEngine;
using System.Collections;

public class femaleQuality : MonoBehaviour {

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
		
		GameObject.Find ("choosepartyBG").GetComponent<choosepartySequence> ().gender = "female";
		Debug.Log ("female");
		
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
