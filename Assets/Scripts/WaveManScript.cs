using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveManScript : MonoBehaviour {

	public float speed = 30f;

	public ShipManagerScript ship;

	private float offset = 0;
	private float spriteWidth;
	private SpriteRenderer[] children;
	public Transform waveContainer;

	public GameObject noConnectionText;
	private float blinkTime = 0;

	// Use this for initialization
	void Start () {
		children = GetComponentsInChildren<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		spriteWidth = 2 * GetComponentInChildren<SpriteRenderer> ().sprite.bounds.extents.x;
		offset += Time.deltaTime * speed;

		while (offset > spriteWidth) {
			offset -= spriteWidth;
		}

		if (ship.radioConnection < ship.minimumConnRequired) {
			blinkTime += Time.deltaTime;
			noConnectionText.SetActive (Mathf.Floor(blinkTime * 3) % 2 == 0);
		} else {
			noConnectionText.SetActive (false);
		}

		waveContainer.localPosition = new Vector3(offset, 0, 0);
		waveContainer.localScale = new Vector3 (1, 0.75f * ship.radioAmplitude / ship.correctAmplitude, 1);
		float diff = 1 - ship.radioConnection;

		for (int i = 0; i < children.Length; i++) {
			children [i].color = new Color (Mathf.Sqrt(diff), Mathf.Sqrt(1 - diff), 0);
		}

	}
}
