using UnityEngine;

using System.Collections;



public class folderQuality : MonoBehaviour {

	public Vector3 originpos;

	public Color colorOver = new Color(1f,0.88f,0.55f); 
	
	public Color colorPushed  = new Color(0.66f,0.66f,0.48f);   
	
	public string level; //If empty quit the application
	
	public bool isdown;

	public string[] messages = {"womp", "donk", "wambo"};

	public string messageis;
	
	public int choice;

	public Vector3 mypos;

	private Color originalColor;

	public GameObject ButtonOne;
	
	
	void Start(){       
		mypos = this.transform.position+new Vector3(0,0,1);
		originalColor = gameObject.renderer.material.color; 
		originpos = gameObject.transform.position;
		isdown = true;

		ButtonOne = GameObject.CreatePrimitive(PrimitiveType.Cube);
		ButtonOne.transform.localScale = new Vector3 (1,1,0);

		
	}

	void Update(){
		mypos = this.transform.position+new Vector3(0,0,-1);
		ButtonOne.transform.position = mypos;

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

			transform.position = new Vector3(13,1.5f,-2);

			for(int i=0;i<10;i++){
				transform.localScale += new Vector3(0.1f,0.1f,0);
			}
			isdown = false;

		} else {

			transform.position = originpos;

			for(int i=0;i<10;i++){
				transform.localScale += new Vector3(-0.1f,-0.1f,0);
			}

			isdown = true;

		}
	}
	
	void OnMouseUpAsButton()        
		
	{       

		
	}

	public string dummy()
	{
		choice = Random.Range(0,2);
		
		messageis = messages[choice];
		
		//Debug.Log (messageis);

		return messageis;

	}
	
}