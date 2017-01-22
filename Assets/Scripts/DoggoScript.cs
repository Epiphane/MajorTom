using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggoScript : MonoBehaviour {

	public Material[] doggos;

	// Use this for initialization
	void Start () {
		Bork ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void Bork () {
		GetComponent<MeshRenderer> ().material = doggos [Random.Range (0, doggos.Length)];
	}
}