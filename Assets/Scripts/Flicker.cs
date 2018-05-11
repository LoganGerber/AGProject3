﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour {

	Light light; 
	public float minWaitTime;
	public float maxWaitTime;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
		StartCoroutine (Flashing ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Flashing()
	{
		while (true) {
			yield return new WaitForSeconds (Random.Range (minWaitTime, maxWaitTime));
			light.enabled = !light.enabled; 
		}
	}
}
