﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisao");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("colisao trigger");
    }
}
