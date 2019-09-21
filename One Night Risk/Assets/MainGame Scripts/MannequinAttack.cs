using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannequinAttack : MonoBehaviour {

    public GameObject Mannequin;
    public GameObject Mannequin1;
    public Transform Mannequin2;

    public GameObject FightAnim;
    public GameObject FlashLight;
    public GameObject FadeScreen;

    public AudioSource Jumpscare;
    public AudioSource Background;
    public AudioSource BreathingHard;
    public AudioSource Ending;

    public static bool bleeding = false;

    public GameObject InventorySlot;

    private bool isActive = false;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && isActive == false && InventorySlot.activeSelf == true)
        {
            FightAnim.GetComponent<Animation>().Play("NearlyKilled");
            isActive = true;
            Mannequin.SetActive(false);
            Mannequin1.SetActive(true);
            FlashLight.SetActive(true);
            Jumpscare.Play();
        }    

        if (isActive == true && Jumpscare.isPlaying == false)
        {
            Ending.Play();
        }

        if (FightAnim.GetComponent<Animation>().IsPlaying("NearlyKilled") == false && isActive == true)
        {
            Mannequin1.SetActive(false);
            Mannequin2.transform.position = new Vector3(223.1249f, 12.75806f, 183.9579f);
            BreathingHard.Play();
            bleeding = true;
            FadeScreen.SetActive(true);
        }
    }
}
