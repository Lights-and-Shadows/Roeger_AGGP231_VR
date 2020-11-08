using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonMjolnir : MonoBehaviour
{
    public GameObject mjolnir;
    
    public void Summon()
    {
        mjolnir.SetActive(true);
    }
}
