using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutCarpet : MonoBehaviour
{

    public GameObject Knife;
    public GameObject LongCarpet;
    public GameObject ShortCarpet;
    public GameObject Key;

    private Ray ray;
    private RaycastHit hit;

    void OnTriggerStay(Collider other)
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Interact") && Knife.activeSelf == true && ReadNotes.CarpetCut == true)
            {
                LongCarpet.SetActive(false);
                ShortCarpet.SetActive(true);
                Key.SetActive(true);
            }
        }    
    }
}
