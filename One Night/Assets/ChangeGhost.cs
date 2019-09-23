using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGhost : MonoBehaviour
{
    public GameObject Ghost1;
    public GameObject Ghost2;
    public GameObject AnotherTrigger;

    public GameObject SpecialDoor;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collide!");
            Ghost1.SetActive(false);
            Ghost2.SetActive(true);
            AnotherTrigger.SetActive(true);

            if (gameObject.CompareTag("Special Door") && SpecialDoor.GetComponent<EntranceDoorOpen>().GetActive() == true)
            {
                SpecialDoor.GetComponent<EntranceDoorOpen>().Close();
            }

            gameObject.SetActive(false);
        }
    }
}
