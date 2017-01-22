using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManagerScript : MonoBehaviour {
	
	public float MAX_FUEL = 30; // Gallons?!?
	public float GOOD_TEMP = 45; // CELSIUS?!?

	public float shipSpeed = 0;
	public float altitude = 0;
	public float wheelsRaised = 0;

    public bool engineOn = false;
	public bool stabilized = true;
	public bool thrusting = false;
	public float temperature = 0;
	public float fuel = 30; // Gallons?!?

	public float heading = 0; // 0 is perfect;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
//		heading += Random.Range (-2, 3);

		if (heading < -75)
			heading = -75;
		if (heading > 75)
			heading = 75;

        if (engineOn) {
            float tpersec = 0.1f + (temperature < GOOD_TEMP ? 0.9f : 0f);

            temperature += tpersec * Time.deltaTime;
        }
    }

    public void PullLever (int leverId) {
    }

	public void IgniteEngine () {
        Debug.Log("ENGINE ON");
        engineOn = true;
	}

	public void SetThrottle (float value) {
	}
}
