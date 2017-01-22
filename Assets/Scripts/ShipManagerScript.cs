using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManagerScript : MonoBehaviour {

    public MajorTomTextDisplayScript majorTomDisplay;

	public float MAX_FUEL = 30; // Gallons?!?
	public float GOOD_TEMP = 90; // CELSIUS?!?

	public float shipSpeed = 0;
	public float altitude = 0;
	public float wheelsRaised = 0;

	public bool stabilized = true;
	public bool thrusting = false;
	public float temperature = 0;
	public float fuel = 30; // Gallons?!?

	public float heading = 0; // 0 is perfect;

	// Use this for initialization
	void Start () {
        majorTomDisplay.Say("You need to pull lever 5 stat!!");
	}
	
	// Update is called once per frame
	void Update () {
//		heading += Random.Range (-2, 3);

		if (heading < -75)
			heading = -75;
		if (heading > 75)
			heading = 75;
	}

    public void PullLever (int leverId) {
        if (leverId == 5) {
            majorTomDisplay.Say("Good job!");
        }
        else {
            majorTomDisplay.Say("That's Not Lever 5 dummy!");
        }
    }

	public void IgniteEngine () {
		
	}

	public void SetThrottle (float value) {
	}
}
