using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonControl : MonoBehaviour {
	public UnityEvent shipFunction;

	private void Start()
	{
		if (shipFunction == null) {
			shipFunction = new UnityEvent ();
		}
	}

	private void handlePush()
	{
		shipFunction.Invoke ();
	}
}