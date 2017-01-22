﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManagerScript : MonoBehaviour {
	
	public float MAX_FUEL = 30; // Gallons?!?
	public float GOOD_TEMP = 45; // CELSIUS?!?

	public float shipSpeed = 0;
	public float altitude = 0;
	public float wheelsRaised = 0;

    public bool engineOn = false;
	public bool stabilized = true;
	public bool thrusting = false;
	public float temperature = 0;
	public float fuel = 30; // Gallons?!?

	public float heading = 0; // 0 is perfect;

	public float radioAmplitude = 0;
	public float correctAmplitude = 90;
	public float radioConnection = 0;
	public float minimumConnRequired = 0.5f;

	public int tutorialState = 0;
	public AudioClip firstMessage;
	public AudioClip secondMessage;
	public AudioClip welcomeMessage;
	public AudioClip proteinPillMessage;
	public AudioClip proteinPillMessage2;
	public AudioClip heatingUpMessage;
	public AudioClip spacebearWarning;
	public AudioClip heatedUpMessage;
	public AudioClip liftoffMessage;

	public AudioSource staticNoise;
	public AudioSource radioNoise;

	public float radioMessageDelay = 0.5f;

	// Use this for initialization
	void Start () {
		if (staticNoise == null) {
			staticNoise = GetComponent<AudioSource> ();
		}

		if (radioNoise == null) {
			radioNoise = transform.GetChild (0).GetComponent<AudioSource> ();
		}
	}

	void PlayOnRadio (AudioClip sound) {
		radioNoise.clip = sound;
		radioNoise.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		// Update Radio messaging
		if (radioMessageDelay > 0) {
			radioMessageDelay -= Time.deltaTime;
		}

		// Update radio connection
		radioConnection = 1 - Mathf.Min(2 * Mathf.Abs (radioAmplitude - correctAmplitude) / correctAmplitude, 1);

		staticNoise.volume = Mathf.Min(1, 1.1f - radioConnection);
		if (radioNoise != null)
			radioNoise.volume = Mathf.Sqrt(radioConnection);

		// Can we talk?
		if (tutorialState == 0) {
			if (radioConnection < minimumConnRequired) {
				radioMessageDelay = 0.5f;
			} else if (radioMessageDelay <= 0) {
				tutorialState = 1;
				PlayOnRadio (firstMessage);

				radioMessageDelay = 5;
			}
		}

		if (tutorialState == 1) {
			if (radioMessageDelay <= 0) {
				PlayOnRadio (secondMessage);
				radioMessageDelay = 9;
			}
		}

		if (tutorialState == 2 && radioMessageDelay <= 0) {
			PlayOnRadio (proteinPillMessage);

			tutorialState = 3;
			radioMessageDelay = 10;
		}

		if (tutorialState == 3 && radioMessageDelay <= 0) {
			PlayOnRadio (proteinPillMessage2);

			tutorialState = 4;
		}

		//if (tutorialState == 5 && radioMessageDelay <= 0) {
		//	PlayOnRadio (spacebearWarning);

		//	tutorialState = 6;
		//}

		if (tutorialState == 5 && temperature >= GOOD_TEMP - 15) {
			PlayOnRadio (heatedUpMessage);

			tutorialState = 6;
		}

		// Heat Engine
		if (engineOn) {
			float tpersec = 0.1f + (temperature < GOOD_TEMP ? 0.9f : 0f);

			temperature += tpersec * Time.deltaTime;

			if (tutorialState == 4) {
				tutorialState = 5;

				PlayOnRadio (heatingUpMessage);

				radioMessageDelay = 25;
			}
		}

//		heading += Random.Range (-2, 3);

		if (heading < -75)
			heading = -75;
		if (heading > 75)
			heading = 75;
    }

	public void AcknowledgeTransmission () {
		if (tutorialState == 1) {
			tutorialState = 2;

			PlayOnRadio (welcomeMessage);

			radioMessageDelay = 21;
		}
	}

	public void IgniteEngine () {
        Debug.Log("ENGINE ON");
        engineOn = true;
	}

    public void DisengageBrakes() {
        Debug.Log("NO BRAKES ON THE SHIP TRAIN");
        if (engineOn && temperature > GOOD_TEMP - 15) {
            thrusting = true;
        }
    }

	public void SetThrottle (float value) {
	}
}
