using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Around : MonoBehaviour {
	public GameObject Model,Pos;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Model.transform.RotateAround(Pos.transform.position,Vector3.up,15*Time.deltaTime); 
	}
}
