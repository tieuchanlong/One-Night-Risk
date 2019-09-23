using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ReadNotes : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;

    public GameObject Note;
    public GameObject Player;

    public static bool CarpetCut = false;

    void OnTriggerStay(Collider other)
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && other.CompareTag("Player"))
        {
            if (Input.GetKeyDown("q"))
            {
                Note.SetActive(true);
                Player.GetComponent<FirstPersonController>().enabled = false;
                if (Note.CompareTag("PartyRoom_note"))
                {
                    CarpetCut = true;
                }
            }
        }
    }

    void Update()
    {
        if (Note.activeSelf == true && Input.GetButtonDown("Interact"))
        {
            Note.SetActive(false);
            Player.GetComponent<FirstPersonController>().enabled = true;
        }    
    }
}
