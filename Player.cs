using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public GameObject GoogleMap,Cam,ModelShow;
	bool CanFight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(CanFight && Input.GetMouseButtonDown(0)){
			Debug.Log("開始戰鬥");

			GoogleMap.SetActive(false);
			Cam.SetActive(true);
			ModelShow.SetActive(true);

		}
	}



	void OnTriggerStay(Collider other){
		if(other.tag == "Dot"){			
			other.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.green;
			other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
			CanFight = true;
		}
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Dot"){
			other.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.white;
			other.gameObject.transform.GetChild(1).gameObject.SetActive(false);
			CanFight = false;
		}
	}


}
