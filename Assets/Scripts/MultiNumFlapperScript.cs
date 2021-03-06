﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiNumFlapperScript : MonoBehaviour {

	public ShipManagerScript ship;

	private NumFlapperScript[] children;

	// Use this for initialization
	void Start () {
		children = GetComponentsInChildren<NumFlapperScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		FlipTo ((int) ship.altitude);
	}

	public void SetNumber (int num) {
		for (int digit = children.Length - 1; digit >= 0; digit--) {
			int value = num % 10;
			children [digit].SetNumber (value);

			num /= 10;
		}
	}

	public void FlipTo (int num) {
		for (int digit = children.Length - 1; digit >= 0; digit--) {
			int value = num % 10;
			children [digit].FlipTo (value);

			num /= 10;
		}
	}
}
