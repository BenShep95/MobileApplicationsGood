using UnityEngine;
using System.Collections;

public class CivilianBehaviour : MonoBehaviour {

	private NavMeshAgent navComponent;
	public Vector3 goal;

	float timer;

	// Use this for initialization
	void Start () 
	{
		timer = 5;
		navComponent = this.GetComponent<NavMeshAgent>();
		//goal = new Vector3(Random.Range(transform.position.x - 1, transform.position.x + 1), transform.position.y, Random.Range (transform.position.z - 1, transform.position.z + 1));
		NewLocation ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;

		if(timer <= 0)
		{
			NewLocation ();
			timer = 5;
		}
		/*if(gameObject.transform.position == goal)
		{
			NewLocation();
		}*/
	}

	void NewLocation()
	{
		goal = new Vector3(Random.Range(transform.position.x - 50, transform.position.x + 50), transform.position.y, Random.Range (transform.position.z - 50, transform.position.z + 50));
		navComponent.SetDestination (goal);
		//print (goal);
	}
}
