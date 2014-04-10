using UnityEngine;
using System.Collections;

public class okayButtonQuality : MonoBehaviour {

	public Color colorOver = new Color(1f,0.88f,0.55f); 
	
	public Color colorPushed  = new Color(0.66f,0.66f,0.48f);  

	private Color originalColor;

	public bool eventint, choosepartyS1, choosepartyS2,choosepartyS3;

	// Use this for initialization
	void Start () {
		originalColor = gameObject.renderer.material.color;  

	}
	
	// Update is called once per frame
	void Update () {

		if (eventint) {

			//Debug.Log ("event interface false");
			transform.position = new Vector3 (GameObject.Find ("interfaceBG").transform.position.x+1, 
			                                  GameObject.Find ("interfaceBG").transform.position.y-0.7f, -5);
			transform.localScale = new Vector3 (0.2f,0.2f,1);
		} else if(choosepartyS1){
			
			transform.position = new Vector3 (GameObject.Find ("choosepartyBG").transform.position.x + 4,
			                                  GameObject.Find ("choosepartyBG").transform.position.y - 1.7f, -3);
			transform.localScale = new Vector3 (0.2f,0.2f,1);
			
			//Debug.Log("stepone false, step two true");
		} else if(choosepartyS2){

			transform.position = new Vector3 (GameObject.Find ("choosepartyBG").transform.position.x + 4,
			                                  GameObject.Find ("choosepartyBG").transform.position.y - 1.7f, -3);
			transform.localScale = new Vector3 (0.2f,0.2f,1);
		
		} else if(choosepartyS3){

			transform.position = new Vector3 (GameObject.Find ("choosepartyBG").transform.position.x + 4,
			                                  GameObject.Find ("choosepartyBG").transform.position.y - 1.7f, -3);
			transform.localScale = new Vector3 (0.2f,0.2f,1);
		} else {
			
			transform.position = new Vector3(20,20,0);
			//Debug.Log("else okay");
		}
	}

	void OnMouseUp(){

		if (eventint) {
			GameObject.Find ("MainCamera").GetComponent<MainGame> ().eventinterface = false;


		} else if(choosepartyS1 && GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().stepOneComplete){
			GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().stepOne = false;
			GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().stepTwo = true;
			GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().stepThree = false;
			GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().Printstepone();
		} else if(choosepartyS2){
			//update variables
			GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().stepOne = false;
			GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().stepTwo = false;
			GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().stepThree = true;
			//GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().Printstepone();

		} else if(choosepartyS3){

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
