using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringNeedleScript : MonoBehaviour {

	public ShipManagerScript ship;

	// Use this for initialization
	void Start () {
		if (ship == null) {
			ship = GameObject.Find ("ShipManager").GetComponent<ShipManagerScript> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.AngleAxis (ship.heading, Vector3.back);
	}
}
