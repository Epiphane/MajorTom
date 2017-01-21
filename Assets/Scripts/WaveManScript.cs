using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManScript : MonoBehaviour {

	public float speed = 30f;

	private Vector3 root;
	private float offset = 0;
	private float spriteWidth;
	private Transform[] children;

	// Use this for initialization
	void Start () {
		spriteWidth = 2 * GetComponentInChildren<SpriteRenderer> ().sprite.bounds.extents.x;
		Debug.Log (spriteWidth);
		root = transform.localPosition;

		children = GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		offset += Time.deltaTime * speed;

		while (offset > spriteWidth) {
			offset -= spriteWidth;
		}

		transform.localPosition = root + new Vector3(offset, 0, 0);
//		transform.localScale = new Vector3(transform.localScale.x, offset > 1 ? 1 : -1, transform.localScale.z);
//		for (int i = 0; i < children.Length; i++) {
//			children [i].localPosition = new Vector3 ((i - 2) * spriteWidth + offset, 0, 0);
//		}
	}
}
