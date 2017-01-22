using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniverseTilerScript : MonoBehaviour {

    public List<GameObject> tilarinos;

    public float offset = 0;

	// Use this for initialization
	void Start () {
        //tilarinos.Sort


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangePos(Vector3 delta) {
        offset += delta.z;
        transform.Translate(delta);

        if (offset > 675) {
            offset -= 675;
        }
    }
}
