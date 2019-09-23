using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWarehouseWardrobe : MonoBehaviour {

	public GameObject Food;
    public GameObject Food1;
    public GameObject Food2;
    public GameObject Food3;
    public GameObject Food4;
    public GameObject Food5;
    public GameObject RealFood;
    public GameObject Cylinder;
    public GameObject InventorySlot;
    public GameObject InsideStuff;

    private bool isActive = false;

    public AudioSource SoundEffect;


    void Update()
    {
        if (Food.activeSelf == true && Food1.activeSelf == true && Food2.activeSelf == true && Food3.activeSelf == true && Food4.activeSelf == true && Food5.activeSelf == true && isActive == false)
        {
                Cylinder.GetComponent<Animation>().Play("DoorOpen");
                isActive = true;
                RealFood.SetActive(false);
                InventorySlot.SetActive(false);
                SoundEffect.Play();
                InsideStuff.SetActive(true);
        }
    }
}
