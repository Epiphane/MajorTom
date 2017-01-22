using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edibles : MonoBehaviour {

    public GameObject urHead;
    public float eatDist = 0.5f;
    public AudioSource om;
    public float howFar;

    // Use this for initialization
    void Start () {
        urHead = GameObject.FindObjectOfType<NewtonVR.NVRHead>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        howFar = Vector3.Distance(transform.position, urHead.transform.position);

        if (howFar < eatDist) {
            Destroy(gameObject);
            var nom = GameObject.Instantiate(om);
            nom.GetComponent<AudioSource>().Play();
        }
     }
}
