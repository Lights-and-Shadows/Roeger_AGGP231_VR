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
            door.transform.rotation = Quaternion.RotateTowards(door.transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * 0.5f);
            isDoorOpen = true;
        }
        else
        {
            door.transform.rotation = Quaternion.RotateTowards(door.transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * 0.5f);
            isDoorOpen = false;
        }
    }
}
