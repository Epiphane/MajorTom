using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MajorTomButtonController : MonoBehaviour {

	public Sprite notSpecial;
	public Sprite hover;
	public Sprite pressed;

	public UnityEvent onPress;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter () {
		GetComponent<SpriteRenderer> ().sprite = hover;
	}

	void OnMouseExit () {
		GetComponent<SpriteRenderer> ().sprite = notSpecial;
	}

	void OnMouseUp () {
		GetComponent<SpriteRenderer> ().sprite = hover;

		GetComponent<AudioSource> ().Play ();
		onPress.Invoke ();
	}

	void OnMouseDown () {
		GetComponent<SpriteRenderer> ().sprite = pressed;
	}
}
