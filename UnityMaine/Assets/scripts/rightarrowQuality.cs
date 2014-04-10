using UnityEngine;
using System.Collections;

public class rightarrowQuality : MonoBehaviour {

	public Color colorOver = new Color(1f,0.88f,0.55f); 
	
	private Color originalColor;
	// Use this for initialization
	void Start () {
		originalColor = gameObject.renderer.material.color; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (GameObject.Find ("choosepartyBG").GetComponent<choosepartySequence> ().i < 5) {
				GameObject.Find ("choosepartyBG").GetComponent<choosepartySequence> ().i += 1;
			//Debug.Log(GameObject.Find ("choosepartyBG").GetComponent<choosepartySequence> ().i);
		} else {
			GameObject.Find ("choosepartyBG").GetComponent<choosepartySequence> ().i = 0;
		}
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
