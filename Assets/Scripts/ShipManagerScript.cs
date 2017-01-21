using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManagerScript : MonoBehaviour {

    public MajorTomTextDisplayScript majorTomDisplay;

    private bool needsLever5Pulled = true;

	public float shipSpeed = 0;
	public float altitude = 0;
	public float wheelsRaised = 0;
	public float engineHeat = 0;

	// Use this for initialization
	void Start () {
        majorTomDisplay.Say("You need to pull lever 5 stat!!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PullLever (int leverId) {
        if (leverId == 5) {
            needsLever5Pulled = false;
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
