﻿using UnityEngine;
using System.Collections;

public class gemaScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision2D coll){
		if (coll.collider Transform.tag == "Player")
}
