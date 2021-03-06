﻿using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ResetColor ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player")
		{
			this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

		}
	}

	void OnMouseDown() {
		GameObject.FindGameObjectWithTag ("Player").GetComponent<NavMeshAI> ().SetDestination (this.gameObject);
		this.gameObject.GetComponent<Renderer>().material.color = Color.red;
	}

	public void ResetColor()
	{
		this.gameObject.GetComponent<Renderer>().material.color = Color.white;
	}
	
}
