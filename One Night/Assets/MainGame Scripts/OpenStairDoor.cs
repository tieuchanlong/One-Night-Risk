using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStairDoor : MonoBehaviour
{

    public GameObject InventorySlot;
    public GameObject Sword;
    public GameObject StairDoor;

    private Ray ray;
    private RaycastHit hit;
    private int count = 0;

    void OnTriggerStay(Collider other)
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("PickUp") && InventorySlot.activeSelf == true && count < 4)
            {
                Sword.GetComponent<Animation>().Play("SwordAnim");
                count++;
                if (count == 4)
                {
                    StairDoor.GetComponent<Animation>().Play("EntranceDoorOpen");
                }
            }
        }
    }
}
