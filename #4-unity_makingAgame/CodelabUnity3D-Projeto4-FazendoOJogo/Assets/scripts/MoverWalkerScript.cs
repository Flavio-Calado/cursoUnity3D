﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverWalkerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * .1f * Time.deltaTime); 
		transform.Rotate(Vector3.up * 3f * Time.deltaTime);		
	}
}
