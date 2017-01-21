using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeverMessage : MonoBehaviour {

    Text myText;
    public int currLeverNum;

	// Use this for initialization
	void Start () {
        myText = GetComponent<Text>();

        currLeverNum = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LeverPulled(int which) {
        SetLeverNumber(which);  
    }

    public void SetLeverNumber(int num) {
        myText.text = "Pulled Lever Number " + num + "!";
        currLeverNum = num;
    }
}
