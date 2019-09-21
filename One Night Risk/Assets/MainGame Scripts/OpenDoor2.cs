using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor2 : MonoBehaviour
{
    public GameObject Cylinder2;
    private bool isActive = false;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Open") && isActive == false)
            {
                Cylinder2.GetComponent<Animation>().Play("DoorOpen2");
                isActive = true;
            }
        }
    }


}
