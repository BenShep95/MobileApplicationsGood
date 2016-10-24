using UnityEngine;
using System.Collections;
//using UnityEditor;
using System.Collections.Generic;

public class GenerateBuldings : MonoBehaviour {

	public GameObject[] tileArray;
	//public GameObject[] buildingArray;
	public List<GameObject> TileList = new List<GameObject> ();

	// Use this for initialization
	void Start ()
	{

		tileArray = GameObject.FindGameObjectsWithTag("BuildingTile");
		//print (tileArray);
		foreach (GameObject tile in tileArray) 
		{
			int i = Random.Range(0, TileList.Count);
			GameObject NewTile = (GameObject) Instantiate(TileList[i], new Vector3 (tile.transform.position.x, tile.transform.position.y, tile.transform.position.z), Quaternion.identity);

			//buildingArray = NewTile.GetComponentsInChildren<Transform>();

			NewTile.transform.rotation = Quaternion.Euler(0, RandRotate(),0);
		}

		//NavMeshBuilder.BuildNavMesh ();

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	float RandRotate()
	{
		int i = Random.Range (0, 3);
		float rot = 90;
		rot *= i;
		return rot;
	}

	void SpawnCivilian()
	{

	}
}
