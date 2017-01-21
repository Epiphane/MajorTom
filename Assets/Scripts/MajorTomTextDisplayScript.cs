using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MajorTomTextDisplayScript : MonoBehaviour {

    private Text output;

	// Use this for initialization
	void Start () {
        output = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Say (string whatToSay) {
        output.text = whatToSay;
    }
}
