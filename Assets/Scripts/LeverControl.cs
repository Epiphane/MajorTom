using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverControl : MonoBehaviour {

    public ShipManagerScript ship;
    public int leverNum;    

    private void Start()
    {
        GetComponent<VRTK.VRTK_Control>().defaultEvents.OnValueChanged.AddListener(HandleChange);
        HandleChange(GetComponent<VRTK.VRTK_Control>().GetValue(), GetComponent<VRTK.VRTK_Control>().GetNormalizedValue());
    }

    private void HandleChange(float value, float normalizedValue)
    {
        ship.PullLever(leverNum);
    }
}