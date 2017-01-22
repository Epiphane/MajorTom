using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnDelay : MonoBehaviour {

    public float delay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        delay -= Time.deltaTime;

        if (delay < 0) {
            GameObject.Destroy(this.gameObject);
        }
	}
}
