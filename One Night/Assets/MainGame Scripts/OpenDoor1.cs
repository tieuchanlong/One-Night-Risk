using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor1 : MonoBehaviour
{
    public GameObject Cylinder1;
    private bool isActive = false;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Open") && isActive == false)
            {
                Cylinder1.GetComponent<Animation>().Play("DoorOpen1");
                isActive = true;
            }
        }
    }


}
