using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;
    private float range;

    public GameObject FakeObject;
    public Transform Player;
    public GameObject InventorySlot;
    public GameObject Name;

    public GameObject Obj;
    public GameObject Obj1;
    public GameObject Obj2;

    public AudioSource SoundEffect;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        range = Vector3.Distance(Player.position, transform.position);

        if (Physics.Raycast(ray, out hit) && range <= 4.5f && Obj.activeSelf == true && Obj1.activeSelf == true && Obj2.activeSelf == true)
        {
            if (Input.GetButtonDown("PickUp"))
            {
                FakeObject.SetActive(false);
                InventorySlot.SetActive(true);
                Name.SetActive(true);
                SoundEffect.Play();
            }
        }
    }
}
