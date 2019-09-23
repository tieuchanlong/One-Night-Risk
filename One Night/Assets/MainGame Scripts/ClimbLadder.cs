using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ClimbLadder : MonoBehaviour
{
    public Transform Player;
    public GameObject FlashLight;
    public AudioSource ChildLaughing;

    private bool inside = false;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetButtonDown("PickUp"))
        {
            Player.transform.position = new Vector3(289.3f, 15.2f, 196.5f);
            FlashLight.GetComponent<Light>().enabled = false;
            ChildLaughing.Stop();
        }    
    }

    
}
