using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverControl : MonoBehaviour {
	
	public UnityEvent shipFunction;

    private void Start()
	{
		if (shipFunction == null) {
			shipFunction = new UnityEvent ();
		}

        GetComponent<VRTK.VRTK_Control>().defaultEvents.OnValueChanged.AddListener(HandleChange);
        HandleChange(GetComponent<VRTK.VRTK_Control>().GetValue(), GetComponent<VRTK.VRTK_Control>().GetNormalizedValue());
    }

	private void HandleChange(float value, float normalizedValue)
    {
		for(int i = 0 ; i < shipFunction.GetPersistentEventCount();i++ ){    
			((MonoBehaviour)shipFunction.GetPersistentTarget(i))
				.SendMessage(shipFunction.GetPersistentMethodName(i), normalizedValue);
		}
    }
}