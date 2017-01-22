using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheelScript : NewtonVR.NVRLetterSpinner {

	public ShipManagerScript ship2;
	public float damping = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float originalRotation = this.transform.localEulerAngles.z;

		base.FixedUpdate ();

		float rotationChange = this.transform.localEulerAngles.z - originalRotation;

		ship.heading += rotationChange * damping;
	}
}
