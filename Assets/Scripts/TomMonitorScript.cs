using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomMonitorScript : MonoBehaviour {

	public Transform homeScreen;
	public Transform engineScreen;
	public Transform proteinScreen;
	public Transform travelLogScreen;

	// Use this for initialization
	void Start () {
		ShowHome ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HideScreens () {
		homeScreen.localPosition = engineScreen.localPosition
			= proteinScreen.localPosition = travelLogScreen.localPosition
			= new Vector3 (0, 10, 0);
	}

	public void ShowHome () {
		HideScreens ();

		homeScreen.localPosition = Vector3.zero;
	}

	public void ShowEngine () {
		HideScreens ();

		engineScreen.localPosition = Vector3.zero;
	}

	public void ShowProtein () {
		HideScreens ();

		proteinScreen.localPosition = Vector3.zero;
	}

	public void ShowTravelLog () {
		HideScreens ();

		travelLogScreen.localPosition = Vector3.zero;
	}
}
