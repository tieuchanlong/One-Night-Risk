using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenDoorOpen : MonoBehaviour
{
    public GameObject Cylinder;
    public GameObject RoomKey;
    public GameObject InventorySlot;

    public AudioSource UnlockSound;
    public AudioSource CreekSound;
    public AudioSource CloseDoor;
    public AudioSource OpenLocked;

    private bool isActive = false;

    private bool unlocked = false;

    private Animation Door;

    void Start()
    {
        Door = Cylinder.GetComponent<Animation>();    
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButton("Open"))
            {
                if (RoomKey.activeSelf == true && InventorySlot.activeSelf == true && isActive == false && unlocked == false)
                {
                    Cylinder.GetComponent<Animation>().Play("WoodenDoorOpen");
                    isActive = true;
                    UnlockSound.Play();
                    StartCoroutine(WaitForHalfSeconds());
                    CreekSound.Play();
                    unlocked = true;
                }
                else 
                {
                    StartCoroutine(WaitForHalfSeconds());
                }

            }

            if (Input.GetButtonDown("Open") && unlocked == true && isActive == true && Door.IsPlaying("WoodenDoorOpen") == false)
            {
                Door["WoodenDoorOpen"].speed = -1;
                Door.Play("WoodenDoorOpen");
                isActive = false;
                CloseDoor.Play();
            }

            if (Input.GetButtonDown("Open") && unlocked == true && isActive == false && Door.IsPlaying("WoodenDoorOpen") == false)
            {
                Door["WoodenDoorOpen"].speed = 1;
                Door.Play("WoodenDoorOpen");
                isActive = true;
                UnlockSound.Play();
                CreekSound.Play();
            }

        }

    }

    IEnumerator WaitForHalfSeconds()
    {
        if (RoomKey.activeSelf == false)
        {
            OpenLocked.Play();
        }
        yield return new WaitForSeconds(1.5f);
        OpenLocked.Stop();
    }


}
