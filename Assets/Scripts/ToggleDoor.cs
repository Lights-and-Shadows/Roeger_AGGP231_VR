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
            if (doorHinge.angle != doorHinge.limits.max)
            {
                door.transform.rotation = Quaternion.Euler(Vector3.right * 5f);
            }
        }
        else
        {
            if (doorHinge.angle != 0f)
            {
                door.transform.rotation = Quaternion.Euler(Vector3.right * -5f);
            }
        }
    }
}
