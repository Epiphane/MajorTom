using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverControl : NewtonVR.NVRLever
{
    public UnityEvent shipFunction;

    private void Start()
    {
        base.Start();
        if (shipFunction == null)
        {
            shipFunction = new UnityEvent();
        }
    }

    public void Update()
    {
        base.Update();

        if (LeverEngaged)
        {
            shipFunction.Invoke();
        }
    }
}