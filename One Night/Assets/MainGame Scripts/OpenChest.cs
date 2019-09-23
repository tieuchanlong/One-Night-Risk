using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public GameObject Cube;
    public GameObject ChestKey;
    public GameObject InventorySlot;
    public GameObject InsideStuff;

    private bool isActive = false;

    public AudioSource SoundEffect;


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Open") && ChestKey.activeSelf == true && InventorySlot.activeSelf == true && isActive == false)
            {
                Cube.GetComponent<Animation>().Play("ChestOpen");
                isActive = true; ;
                SoundEffect.Play();
                InsideStuff.SetActive(true);
            }
        }
    }


}
