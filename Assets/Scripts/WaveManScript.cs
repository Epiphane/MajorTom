using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManScript : MonoBehaviour {

	public float speed = 30f;
	public float currentAmp = 60.0f;
	public float correctAmp = 90.0f;

	public AudioSource staticNoise;
	public AudioSource radioNoise;

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
		transform.localScale = new Vector3 (1, 0.75f * currentAmp / correctAmp, 1);
		float diff = Mathf.Min(2 * Mathf.Abs (currentAmp - correctAmp) / correctAmp, 1);

		staticNoise.volume = diff;
		radioNoise.volume = 1 - Mathf.Sqrt(diff);

		for (int i = 1; i < children.Length; i++) {
			children [i].localPosition = new Vector3((i - 2) * spriteWidth, 0, 0);
			children [i].GetComponent<SpriteRenderer> ().color = new Color (Mathf.Sqrt(diff), Mathf.Sqrt(1 - diff), 0);
		}

	}
}
