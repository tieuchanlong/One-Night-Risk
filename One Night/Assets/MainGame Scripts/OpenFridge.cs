using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridge : MonoBehaviour
{
    public GameObject Cube;
    public GameObject InventorySlot;
    public GameObject Knife;
    public GameObject Name;
    public GameObject Instruction;

    private bool isActive = false;
    private bool Instruct_appear;

    public AudioSource SoundEffect;


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (Knife.activeSelf == true && isActive == false)
                {
                    Cube.GetComponent<Animation>().Play("FridgeOpen");
                    isActive = true;
                    InventorySlot.SetActive(true);
                    Name.SetActive(true);
                    SoundEffect.Play();
                }

            }
            else
            {
                if (Instruct_appear == false)
                {
                    Instruction.SetActive(true);
                    Instruct_appear = true;
                }
            }
        }
    }

}
