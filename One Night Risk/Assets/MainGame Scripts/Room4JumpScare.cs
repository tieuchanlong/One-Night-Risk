using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4JumpScare : MonoBehaviour {

    public GameObject InventorySlot;
    public GameObject UpLight;
    public GameObject FlashLight;

    public AudioSource Jumpscare;

    private bool isActive = false;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && InventorySlot.activeSelf == true)
        {
            UpLight.GetComponent<DollAppear>().enabled = true;
            if (isActive == false)
            {
                FlashLight.GetComponent<Light>().enabled = false;
                isActive = true;
                Jumpscare.Play();
            }
        }        
    }
}
