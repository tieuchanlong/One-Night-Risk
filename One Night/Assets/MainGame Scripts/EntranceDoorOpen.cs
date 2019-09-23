using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceDoorOpen : MonoBehaviour
{
    public GameObject Cylinder;
    public GameObject EntranceKey;
    public GameObject InventorySlot;

    public AudioSource CreekSound;
    public AudioSource CloseDoor;

    private bool isActive = false;
    private bool unlocked = false;

    public static bool PeopleAppear = false;

    private Animation Door;

    void Start()
    {
        Door = Cylinder.GetComponent<Animation>();   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Open") && isActive == false && unlocked == false)
            {
                if ((EntranceKey.activeSelf == true && InventorySlot.activeSelf == true) || this.CompareTag("Entrance") == false)
                {
                    Cylinder.GetComponent<Animation>().Play("EntranceDoorOpen");
                    isActive = true;
                    CreekSound.Play();
                    unlocked = true;
                }

                if (this.CompareTag("KitchenDoor"))
                {
                    PeopleAppear = false;
                }
            }

            if (Input.GetButtonDown("Open") && unlocked == true && isActive == true && Door.IsPlaying("EntranceDoorOpen") == false)
            {
                Door["EntranceDoorOpen"].speed = -1;
                Door.Play("EntranceDoorOpen");
                isActive = false;
                CloseDoor.Play();

                if (this.CompareTag("KitchenDoor"))
                {
                    PeopleAppear = true;
                }
            }

            if (Input.GetButtonDown("Open") && unlocked == true && isActive == false && Door.IsPlaying("EntranceDoorOpen") == false)
            {
                Door["EntranceDoorOpen"].speed = 1;
                Door.Play("EntranceDoorOpen");
                isActive = true;
                CreekSound.Play();

                if (this.CompareTag("KitchenDoor"))
                {
                    PeopleAppear = false;
                }
            }
        }
    }

    public bool GetActive()
    {
        return isActive;
    }

    public void Close()
    {
        isActive = !isActive;
        Door["EntranceDoorOpen"].speed = -1;
        Door.Play("EntranceDoorOpen");
        isActive = false;
        CloseDoor.Play();
    }


}
