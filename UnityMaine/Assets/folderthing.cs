using UnityEngine;

using System.Collections;



public class folderthing : MonoBehaviour {
	
	
	
	public Color colorOver = new Color(1f,0.88f,0.55f); 
	
	public Color colorPushed  = new Color(0.66f,0.66f,0.48f);   
	
	public string level; //If empty quit the application
	
	public bool isdown;

	public string[] messages = {"LOOK WHAT HAPPENED TO JUSTIN BEIBER", "WHO ARE YOU PEOPLE?", "MINUS ALL TO PRODUCTIVITY"};

	public string messageis;
	
	public int choice;

	private Color originalColor;
	
	
	
	void Start(){       
		
		originalColor = gameObject.renderer.material.color; 

		isdown = true;
		
	}
	
	
	
	void OnMouseEnter()     
		
	{
		
		gameObject.renderer.material.color= colorOver;
		
	}   
	
	
	
	void OnMouseExit()
		
	{
		
		gameObject.renderer.material.color= originalColor;
		
	}
	
	
	
	void OnMouseDown()
		
	{
		
		gameObject.renderer.material.color= colorPushed;
		
	}
	
	void OnMouseUp()
	{
		gameObject.renderer.material.color = originalColor;

		Debug.Log (dummy ());

		if(isdown == true){

			transform.Translate (Vector2.up * 150 * Time.deltaTime);



			isdown = false;

		} else {

			transform.Translate (Vector2.up * -150 * Time.deltaTime);

			isdown = true;

		}
	}
	
	void OnMouseUpAsButton()        
		
	{       
		
		if(level.Length>0)
			
			Application.LoadLevel(level);
		
		else
			
			Application.Quit();
		
	}

	public string dummy()
	{
		choice = Random.Range(0,2);
		
		messageis = messages[choice];
		
		//Debug.Log (messageis);

		return messageis;

	}
	
}