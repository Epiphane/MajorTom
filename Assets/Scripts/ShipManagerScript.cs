using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManagerScript : MonoBehaviour {

    public MajorTomTextDisplayScript majorTomDisplay;

    private bool needsLever5Pulled = true;

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
}
