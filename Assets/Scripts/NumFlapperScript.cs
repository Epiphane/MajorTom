using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumFlapperScript : MonoBehaviour {

	public float flipSpeed = 600;
	public SpriteRenderer top;
	public SpriteRenderer bottom;
	public Transform flipper;
	public SpriteRenderer flap;

	public Sprite[] top_sprites;
	public Sprite[] bottom_sprites;

	private float flip = 0;
	private int flippingTo = -1;
	private int current = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (flippingTo >= 0) {
			flip = Mathf.Min(180, flip + Time.deltaTime * flipSpeed);

			flipper.rotation = Quaternion.AngleAxis(-flip, new Vector3 (1, 0, 0));

			if (flip > 90) {
				flap.sprite = bottom_sprites [flippingTo];
				flap.transform.localScale = new Vector3 (1, -1, 1);
			}
			if (flip > 160) {
				bottom.sprite = bottom_sprites [flippingTo];
			}
			if (flip == 180) {
				flap.sprite = top_sprites[flippingTo];
				flipper.rotation = Quaternion.AngleAxis(0, new Vector3 (1, 0, 0));
				flap.transform.localScale = new Vector3 (1, 1, 1);

				flippingTo = -1;
			}
		}
	}

	public void SetNumber (int num) {
		flap.sprite = top_sprites[num];
		flipper.rotation = Quaternion.AngleAxis(0, new Vector3 (1, 0, 0));
		flap.transform.localScale = new Vector3 (1, 1, 1);

		top.sprite  = top_sprites[num];
		bottom.sprite = bottom_sprites [num];

		flippingTo = -1;
	}

	public void FlipTo (int num) {
		if (num == current || flippingTo >= 0)
			return;

		flippingTo = num;
		flip = 0;
		current = flippingTo;
	
		top.sprite = top_sprites [num];
	}
}
