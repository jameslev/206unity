using UnityEngine;
using System.Collections;

public class principleQuality: MonoBehaviour {

	public Color colorOver = new Color(1f,0.88f,0.55f); 
	
	private Color originalColor;

	public bool infoShown;

	public GameObject childObj;

	public Vector3 myPos;



	// Use this for initialization
	void Start () {
		originalColor = gameObject.renderer.material.color;
		myPos = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		if(gameObject.transform.name.Equals("antipollution")){
			childObj = GameObject.Find("antipoText");
		} else if(gameObject.transform.name.Equals("guncontrol")){
			childObj = GameObject.Find("guncontrolText");
			myPos.z = myPos.z-.01f;
		} else if(gameObject.transform.name.Equals("recycle")){
			childObj = GameObject.Find("recycleText");
			myPos.z = myPos.z-.03f;
		}
		childObj.transform.position = myPos;
	}
	
	// Update is called once per frame
	void Update () {

		if(GameObject.Find("choosepartyBG").GetComponent<choosepartySequence>().stepTwo && !infoShown){
			if(gameObject.transform.name.Equals("antipollution")){

			} else if(gameObject.transform.name.Equals("guncontrol")){

			} else if(gameObject.transform.name.Equals("recycle")){

			}
		}
	
	}

	void OnMouseUp(){




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
