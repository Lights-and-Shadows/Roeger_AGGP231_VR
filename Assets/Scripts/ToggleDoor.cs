using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleDoor : MonoBehaviour
{
    [SerializeField]
    private bool isDoorOpen = false;

    public HingeJoint doorHinge;
    public GameObject door;
    public void ToggleTheDoor()
    {
        if (!isDoorOpen)
        {
            door.transform.Rotate(0f, 0f, doorHinge.limits.min);
            isDoorOpen = true;
        }
        else
        {
            door.transform.Rotate(0f, 0f, doorHinge.limits.max);
            isDoorOpen = false;
        }
    }
}
