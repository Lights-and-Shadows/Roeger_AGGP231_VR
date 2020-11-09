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

    public Vector3 oldRot, newRot;

    public void Start()
    {
        oldRot = door.transform.eulerAngles;
        newRot = new Vector3(0, 0, doorHinge.limits.min);
    }
    public void ToggleTheDoor()
    {
        if (!isDoorOpen)
        {
            door.transform.Rotate(0f, 0f, -5f);
            isDoorOpen = true;
        }
        else
        {
            door.transform.Rotate(0f, 0f, 5f);
            isDoorOpen = false;
        }
    }
}
