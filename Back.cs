using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {
	public GameObject GoogleMap,Cam,ModelShow;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//function名稱可以自訂
	void ClickToBack(){
		GoogleMap.SetActive(true);
		Cam.SetActive(false);
		ModelShow.SetActive(false);
	}
}
