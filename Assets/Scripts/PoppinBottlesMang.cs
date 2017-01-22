using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoppinBottlesMang : MonoBehaviour {

    float timeTillPill = 0;
    float MAX_TIME_TO_PILL = 0.8f;
    float diffDown = 0.2f;

    public GameObject pillTemplate;
    public bool open;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Dot(transform.up, Vector3.down) > 0.8f) {
            timeTillPill -= Time.deltaTime;
            
            if (timeTillPill < 0 && open) {
                timeTillPill = MAX_TIME_TO_PILL;
                // spawn pill
                GameObject.Instantiate(pillTemplate, transform.position + (transform.localRotation * (Vector3.up * diffDown)), Quaternion.AngleAxis(0, Vector3.down));
            }
        }
    }
}
