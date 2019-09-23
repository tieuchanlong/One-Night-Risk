using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneRinging : MonoBehaviour
{

    public GameObject Note;
    public GameObject CandleFire;
    public GameObject Bears;
    public GameObject Dolls;

    public AudioSource SoundEffect;
    public AudioSource ChildLaughing;

    private Ray ray;
    private RaycastHit hit;

    private bool phone_ring = false;
    private bool pickup = false;

    void Update()
    {
        if (Note.activeSelf == true)
        {
            phone_ring = true;
        }    

        if (Note.activeSelf == false && phone_ring == true && pickup == false)
        {
            SoundEffect.Play();
            pickup = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (other.CompareTag("Player") && Physics.Raycast(ray, out hit) && Input.GetButtonDown("PickUp"))
        {
            SoundEffect.Stop();
            ChildLaughing.Play();
            CandleFire.SetActive(true);
            Bears.SetActive(false);
            Dolls.SetActive(true);
        }    
    }

}
