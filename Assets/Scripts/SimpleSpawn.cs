using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawn : MonoBehaviour {

	public GameObject ToSpawn = null;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SpawnObject()
	{
		GameObject.Instantiate(ToSpawn);
	}
}
