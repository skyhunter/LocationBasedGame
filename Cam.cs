using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		WebCamTexture c = new WebCamTexture (); //設定視訊攝影鏡頭材質
		gameObject.GetComponent<UITexture> ().mainTexture = c; //替換掉物件本身的材質
		c.Play (); //開始撥放攝影機
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
