using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoppinBottles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnJointBreak(float breakForce) {
        GetComponent<AudioSource>().Play();
        FindObjectOfType<PoppinBottlesMang>().open = true;
    }
}
