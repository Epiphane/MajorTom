using UnityEngine;
using System.Collections;

public class AudioTransitionScript : MonoBehaviour {

    public AudioSource next = null;
    public AudioSource mine = null;

    private bool playing = false;

	// Use this for initialization
	void Start () {
	    if (!mine) {
            mine = GetComponent<AudioSource>();
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (playing && !mine.isPlaying) {
            playing = false;
            
            if (next) {
                Debug.Log("Go!");
                next.Play();
            }
        }
        playing = mine.isPlaying;
    }
}
