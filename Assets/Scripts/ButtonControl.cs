using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonControl : NewtonVR.NVRButton {
	public UnityEvent shipFunction;

	private void Start()
	{
		if (shipFunction == null) {
			shipFunction = new UnityEvent ();
		}
	}

    public override void Update() {
        base.Update();

        if (ButtonDown) {
            handlePush();
        }
    }

	private void handlePush()
	{
		shipFunction.Invoke ();
	}
}