using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Cylinder;
    public GameObject WardDrobeKey;
    public GameObject Slot;
    public GameObject InsideStuff;

    private bool isActive = false;

    public AudioSource SoundEffect;
    public AudioSource OpenLocked;


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Open"))
            {
                if (WardDrobeKey.activeSelf == true && Slot.activeSelf == true && isActive == false)
                {
                    Cylinder.GetComponent<Animation>().Play("DoorOpen");
                    isActive = true; WardDrobeKey.SetActive(false); Slot.SetActive(false);
                    SoundEffect.Play();
                    InsideStuff.SetActive(true);
                }
                else
                {
                    StartCoroutine(WaitForHalfSeconds());
                }
            }
        }
    }

    IEnumerator WaitForHalfSeconds()
    {
        if (isActive == false)
        {
            OpenLocked.Play();
        }
        yield return new WaitForSeconds(1.2f);
        OpenLocked.Stop();
    }

    public bool GetActive()
    {
        return isActive;
    }


}
