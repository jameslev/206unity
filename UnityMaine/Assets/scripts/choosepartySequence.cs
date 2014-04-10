using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class choosepartySequence : MonoBehaviour {
	public bool stepOne,stepTwo,stepOneComplete, stepTwoComplete,stepThree,stepThreeComplete;
	public string partyname;
	public string partyabb;
	public string partymotto;
	public string playername;
	public string gender;
	public int i;
	public List<GameObject> icons;
	public Vector2 scrollposition,scroll2;
	public Texture2D recycle = Resources.Load("textures/recycle") as Texture2D;

	// Use this for initialization
	void Start () {
		i = 0;
		icons = new List<GameObject>();

		icons.Add (GameObject.Find("iconpen"));
		icons.Add (GameObject.Find("iconfemale"));
		icons.Add (GameObject.Find("icongreen"));
		icons.Add (GameObject.Find("iconpencil"));
		icons.Add (GameObject.Find("iconquote"));
		icons.Add (GameObject.Find("iconsoup"));

	}

	public void Printstepone (){
		
		Debug.Log (partyname);
		Debug.Log (partyabb);
		Debug.Log (partymotto);
		Debug.Log (playername);
		Debug.Log (gender);
		Debug.Log (i);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		float frameX = GameObject.Find ("choosepartyBG").transform.position.x+100;
		float frameY = GameObject.Find ("choosepartyBG").transform.position.y+100;
		if (stepOne) {
				GUI.Label (new Rect (frameX, frameY + 20, 300, 20), "Party Name: ");
				partyname = GUI.TextField (new Rect (frameX + 150, frameY + 20, 300, 20), partyname,30);

				GUI.Label (new Rect (frameX, frameY + 40, 300, 20), "Party Abbreviation: ");
				partyabb = GUI.TextField (new Rect (frameX + 150, frameY + 40, 50, 20), partyabb,3);

				GUI.Label (new Rect (frameX, frameY + 60, 300, 20), "Party Motto: ");
				partymotto = GUI.TextField (new Rect (frameX + 150, frameY + 60, 300, 20), partymotto,50);

				GUI.Label (new Rect (frameX, frameY + 80, 300, 20), "Your Name: ");
				playername = GUI.TextField (new Rect (frameX + 150, frameY + 80, 300, 20), playername,30);

				GUI.Label (new Rect (frameX, frameY + 120, 300, 20), "Gender: ");
				GameObject.Find ("male").transform.position = new Vector3 (GameObject.Find ("choosepartyBG").transform.position.x - 1.5f,
	                                                         GameObject.Find ("choosepartyBG").transform.position.y - 0.4f, -2);
				GameObject.Find ("female").transform.position = new Vector3 (GameObject.Find ("choosepartyBG").transform.position.x - 0.5f,
	                                                         GameObject.Find ("choosepartyBG").transform.position.y - 0.4f, -2);

				GameObject.Find ("male").transform.localScale = new Vector3 (0.3f, 0.3f, 1);
				GameObject.Find ("female").transform.localScale = new Vector3 (0.3f, 0.3f, 1);

				GameObject.Find ("arrowright").transform.position = new Vector3 (GameObject.Find ("choosepartyBG").transform.position.x + 1,
	                                                               GameObject.Find ("choosepartyBG").transform.position.y - 1.2f, -4);
				GameObject.Find ("arrowleft").transform.position = new Vector3 (GameObject.Find ("choosepartyBG").transform.position.x - 1,
	                                                               GameObject.Find ("choosepartyBG").transform.position.y - 1.2f, -4);

				GameObject.Find ("arrowright").transform.localScale = new Vector3 (0.1f, 0.1f, 1);
				GameObject.Find ("arrowleft").transform.localScale = new Vector3 (0.1f, 0.1f, 1);

				icons [i].transform.position = new Vector3 (GameObject.Find ("choosepartyBG").transform.position.x + 0,
	                                          GameObject.Find ("choosepartyBG").transform.position.y - 1.4f, -3);
				
				icons [i].transform.localScale = new Vector3 (0.08f, 0.08f, 1);

				for (int n=0; n<6; n++) {
						if (n != i) {
								icons [n].transform.position = new Vector3 (20, 20, 0);
						}
				}
	
				GUI.Label (new Rect (frameX, frameY + 200, 300, 20), "Party Icon: ");

				if(!partyname.Equals("")&&!partyabb.Equals("")&&!partymotto.Equals("")&&!playername.Equals("")&&!gender.Equals("")){
					stepOneComplete=true;
				}

				GameObject.Find ("okbutton").GetComponent<okayButtonQuality> ().choosepartyS1 = true;

		} else {

			GameObject.Find ("okbutton").GetComponent<okayButtonQuality> ().choosepartyS1 = false;
			GameObject.Find("arrowright").transform.position = new Vector3(20,20,0);
			GameObject.Find("arrowleft").transform.position = new Vector3(20,20,0);
			GameObject.Find ("male").transform.position = new Vector3(20,20,0);
			GameObject.Find ("female").transform.position = new Vector3(20,20,0);

			for (int n=0; n<6; n++) {

				icons[n].transform.position = new Vector3 (20, 20, 0);
				
			}
		}
		if (stepTwo) {

			int[] bannerPosition = {100,200,300,400};
			GameObject.Find ("okbutton").GetComponent<okayButtonQuality> ().choosepartyS2 = true;
			scrollposition = GUI.BeginScrollView(new Rect(100, 120, 370, 200), scrollposition, new Rect(0, 0, 820, 500));
			GUI.Button(new Rect(30, 0, 600, 400), recycle);
			GUI.Button(new Rect(30, 100, 300, 50), "Anti-Pollution");
			GUI.Button(new Rect(30, 200, 300, 50), "Gun Control");
			GUI.Button(new Rect(30, 300, 300, 50), "Money As Speech");

			GUI.EndScrollView();
		} else {

		}

		if(stepThree){
			scroll2 = GUI.BeginScrollView(new Rect(100, 120, 370, 200), scrollposition, new Rect(0, 0, 320, 500));

			GUI.EndScrollView();
			

		} else {

		}
	}
}
