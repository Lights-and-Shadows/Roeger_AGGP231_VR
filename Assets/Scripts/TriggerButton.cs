﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerButton : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onButtonPressed;

    private bool pressedInProgress = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ButtonActivator" && !pressedInProgress)
        {
            pressedInProgress = true;
            onButtonPressed.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ButtonActivator")
        {
            pressedInProgress = false;
        }
    }
}
