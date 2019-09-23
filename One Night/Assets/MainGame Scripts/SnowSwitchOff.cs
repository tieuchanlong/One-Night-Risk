using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSwitchOff : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        SnowMonitor.OnSnow = 0;
    }
}
