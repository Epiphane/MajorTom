using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioAmplitudeController : MonoBehaviour {

	public ShipManagerScript ship;
	private Slider mySlider;

	// Use this for initialization
	void Start () {
		mySlider = GetComponent<Slider> ();

		ship.radioAmplitude = mySlider.minValue;
	}
	
	// Update is called once per frame
	void Update () {
		ship.radioAmplitude = mySlider.value;

//		if (Random.Range (0, 500) < 2) {
//			mySlider.value += Random.Range (-20, 20);
//		}
	}
}
