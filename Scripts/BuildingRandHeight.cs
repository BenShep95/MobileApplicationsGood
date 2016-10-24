using UnityEngine;
using System.Collections;
//using UnityEditor;

public class BuildingRandHeight : MonoBehaviour {

	public Transform[] buildingArray;
	Vector3 randomheight;

	public GameObject[] Tiles;

	float timer = 4;

	// Use this for initialization
	void Start () 
	{
		ChangeHeight ();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void ChangeHeight()
	{
		//gets each transform compnent in children 
		buildingArray = gameObject.GetComponentsInChildren<Transform> ();

		//looping through the buildings and randomly altering the height of each building
		for (int i = 1; i < buildingArray.Length; i++) 
		{
			randomheight = buildingArray [i].transform.localScale;
			randomheight.y += Random.Range (0, 7);
			buildingArray [i].transform.localScale = randomheight;
		}

		//Findng all the tile blocks
		Tiles = GameObject.FindGameObjectsWithTag ("Tile");

		//looping through all the tile blocks and randomly rotating them
		foreach(GameObject tile in Tiles)
		{
			tile.transform.rotation = Quaternion.Euler(0, RandRotate(),0);
		}
	}


	//Random rotation funtion that returns a float 
	float RandRotate()
	{
		int i = Random.Range (0, 3);
		float rot = 90;
		rot *= i;
		return rot;
	}
}
