using UnityEngine;
using System.Collections;

public class NavMeshAI : MonoBehaviour {

	private GameObject destination;

	// Use this for initialization
	void Start () {
		destination = null;
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<NavMeshAgent> ().destination = destination.transform.position;
	}


	public void SetDestination(GameObject dest)
	{
		destination = dest;

		foreach(GameObject node in GameObject.FindGameObjectsWithTag("Node"))
		{
			node.GetComponent<Node>().ResetColor();
		}

	}


}
