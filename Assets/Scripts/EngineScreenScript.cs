using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineScreenScript : MonoBehaviour {

	public ShipManagerScript ship;
	public Text stabilizers;
	public Text thrusters;
	public Text fuel;
	public Text temperature;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		stabilizers.text = ship.engineOn ? "On" : "Off";
		stabilizers.color = ship.engineOn ? Color.green : Color.red;

		thrusters.text = ship.thrusting ? "Thrusting" : "Disengaged";
		thrusters.color = ship.thrusting ? Color.green : Color.red;

		fuel.text = "Full";
		fuel.color = Color.green;
		if (ship.fuel < ship.MAX_FUEL * 2 / 3)
			fuel.text = "Satisfied";
		if (ship.fuel < ship.MAX_FUEL / 3) {
			fuel.text = "Getting Low";
			fuel.color = Color.yellow;
		}
		if (ship.fuel == 0) {
			fuel.text = "Finished";
			fuel.color = Color.red;
		}

		temperature.text = Mathf.Floor(ship.temperature).ToString () + "°";
		float diff = Mathf.Abs(ship.temperature - ship.GOOD_TEMP);
		temperature.color = Color.blue;
		if (ship.temperature - ship.GOOD_TEMP > -20)
			temperature.color = Color.cyan;
		if (ship.temperature - ship.GOOD_TEMP > 0)
			temperature.color = Color.green;
		if (ship.temperature - ship.GOOD_TEMP > 20)
			temperature.color = Color.yellow;
		if (ship.temperature - ship.GOOD_TEMP > 40)
			temperature.color = Color.red;
	}
}
