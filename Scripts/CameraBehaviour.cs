using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {
		
	public float dampTime = 1f;
	private Vector3 velocity = Vector3.zero;
	public GameObject target;

	public bool gameStarted = false;
	GameObject currentTarget;
	public GameObject p1;
		
	void Start()
	{
		target = GameObject.FindGameObjectWithTag ("Player");
		currentTarget = p1;
		SwitchPositions ();

	}

	// Update is called once per frame
	void Update () 
	{
		if(!gameStarted)
			transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, .1f);
		else
			transform.position = Vector3.Lerp(transform.position, new Vector3(target.transform.position.x,transform.position.y,target.transform.position.z), dampTime);
	

		if (transform.position == currentTarget.transform.position)
		{
			SwitchPositions ();
		}
	}	

	void SwitchPositions()
	{
		//int randRange = Random.Range (1,4);

		currentTarget.transform.position = new Vector3(Random.Range(-70,70),transform.position.y,Random.Range(-70,70));

		/*if(randRange == 1)
			currentTarget = p2;
		else if(randRange == 2)
			currentTarget = p3;
		else if(randRange == 3)
			currentTarget = p4;
		else if(randRange == 4)
			currentTarget = p1;*/
		/*if (currentTarget.transform.position == p1.transform.position)
			currentTarget = p2;
		else if(currentTarget.transform.position == p2.transform.position)
			currentTarget = p3;
		else if(currentTarget.transform.position == p3.transform.position)
			currentTarget = p4;
		else if(currentTarget.transform.position == p4.transform.position)
			currentTarget = p1;*/
	}


}
