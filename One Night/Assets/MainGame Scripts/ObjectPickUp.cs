using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUp : MonoBehaviour
{

    private Ray ray;
    private RaycastHit hit;
    private float range;

    public GameObject FakeObject;
    public Transform Player;
    public GameObject InventorySlot;
    public GameObject Name;

    public AudioSource SoundEffect;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        range = Vector3.Distance(Player.position, transform.position);

        if (Physics.Raycast(ray, out hit) && range <= 4.5f)
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
