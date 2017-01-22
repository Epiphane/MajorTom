using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class UniverseTilerScript : MonoBehaviour {

    public List<GameObject> tilarinos;

    public float offset = 0;

	// Use this for initialization
	void Start () {
        tilarinos.Sort((x, y) => x.transform.position.z.CompareTo(y.transform.position.z));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangePos(Vector3 delta) {
        offset -= delta.z;
        transform.Translate(delta);

        if (offset > 675) {
            offset -= 675;
            var switcher = tilarinos[0];
            tilarinos.RemoveAt(0);
            switcher.transform.Translate(new Vector3(0, 0, 675 * (tilarinos.Count + 1)));
            tilarinos.Add(switcher);
        }
    }
}
