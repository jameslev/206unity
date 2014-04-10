using UnityEngine;
using System.Collections;

public class member : MonoBehaviour {

	public int speech;
	public int presence;
	public int morality;

	//knowledge
	public int kGunControl;
	public int kPollution;
	public int kRecycling;

	//opinions
	public int oGunControl;
	public int oPollution;
	public int oRecycling;

	public int reputation;
	public int loyalty;

	// Use this for initialization
	void Start () {

		speech = Random.Range (0,3);
		presence = Random.Range (0,3);
		morality = Random.Range (0,3);

		kGunControl = Random.Range (0,3);
		kPollution = Random.Range (0,3);
		kRecycling = Random.Range (0,3);

		oGunControl = Random.Range (0,3);
		oPollution = Random.Range (0,3);
		oRecycling = Random.Range (0,3);

		reputation = Random.Range (0,3);
		loyalty = Random.Range (0,3);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void officerBeahvior(){

	}
}
