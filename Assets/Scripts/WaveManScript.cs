using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManScript : MonoBehaviour {

	public float speed = 30f;

	public ShipManagerScript ship;

	private Vector3 root;
	private float offset = 0;
	private float spriteWidth;
	private Transform[] children;

	// Use this for initialization
	void Start () {
		root = transform.localPosition;

		children = GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		spriteWidth = 2 * GetComponentInChildren<SpriteRenderer> ().sprite.bounds.extents.x;
		offset += Time.deltaTime * speed;

		while (offset > spriteWidth) {
			offset -= spriteWidth;
		}

		transform.localPosition = root + new Vector3(offset, 0, 0);
		transform.localScale = new Vector3 (1, 0.75f * ship.radioAmplitude / ship.correctAmplitude, 1);
		float diff = 1 - ship.radioConnection;

		for (int i = 1; i < children.Length; i++) {
			children [i].localPosition = new Vector3((i - 2) * spriteWidth, 0, 0);
			children [i].GetComponent<SpriteRenderer> ().color = new Color (Mathf.Sqrt(diff), Mathf.Sqrt(1 - diff), 0);
		}

	}
}
