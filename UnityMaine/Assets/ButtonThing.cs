using UnityEngine;

using System.Collections;



public class ButtonThing : MonoBehaviour {
	
	//folderthing mess = a
	
	public Color colorOver = new Color(1f,0.88f,0.55f); 
	
	public Color colorPushed  = new Color(0.66f,0.66f,0.48f);   
	
	public string level; //If empty quit the application
	
	private GUIText[] txtmsgs;
	public Font font;
	private int cur;
	private float ypos;
	
	private Color originalColor;
	
	
	
	void Start(){       
		
		originalColor = gameObject.renderer.material.color;  

		//GameObject message = new GameObject("GUIText");
		//txtmsgs[0] = (GUIText)message.AddComponent(typeof(GUIText));
		cur = 1;
		ypos = 1.0f;
		txtmsgs = new GUIText[5];
		
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

		
		GameObject message = new GameObject("GUIText");
		//message.AddComponent("TimeDummy");
		txtmsgs[cur] = (GUIText)message.AddComponent(typeof(GUIText));
		txtmsgs[cur].text = "Event Happening!";
		txtmsgs[cur].transform.position = (new Vector2(0.637058f,ypos));
		
		Debug.Log(txtmsgs[cur].transform.position);
		cur++;

	}
	
	void OnMouseUpAsButton()        
		
	{       
		
		if(level.Length>0)
			
			Application.LoadLevel(level);
		
		else
			
			Application.Quit();
		
	}
	
}