using UnityEngine;
using System.Collections;

public class TimeDummy : MonoBehaviour {

	private GUIText[] txtmsgs;
	public Font font;
	private int cur;
	private float ypos;

	void Start()
		
	{
		txtmsgs = new GUIText[5];
		cur = 1;
		ypos = 1.0f;
		GameObject message = new GameObject("GUIText");
		txtmsgs[0] = (GUIText)message.AddComponent(typeof(GUIText));
		StartCoroutine("MyEvent");
		
	}
	
	
	
	private IEnumerator MyEvent()
		
	{
		
		while(true)
			
		{

			yield return new WaitForSeconds(100.0f); 


			GameObject message = new GameObject("GUIText");
			message.AddComponent("TimeDummy");
			txtmsgs[cur] = (GUIText)message.AddComponent(typeof(GUIText));
			txtmsgs[cur].text = "Event Happening!";
			txtmsgs[cur].transform.position = (new Vector2(0.637058f,ypos));

			Debug.Log(txtmsgs[cur].transform.position);

				//txtmsgs[i].transform.position = Vector2.MoveTowards(transform.position,new Vector2(0.637058f,newpos), 10.0f);
			//if(gameObject.GetComponent<GUIText> == null){
			//	transform.position += Vector3.down;
				//newpos +=0.1f;

			//}

			cur++;
			yield return new WaitForEndOfFrame();

		}

	}
}
