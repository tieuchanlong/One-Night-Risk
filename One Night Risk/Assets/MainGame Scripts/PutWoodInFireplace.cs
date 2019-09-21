using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutWoodInFireplace : MonoBehaviour
{

    private Ray ray;
    private RaycastHit hit;
    private float range;

    public Transform Player;
    public GameObject Wood;
    public GameObject FakeWood;
    public GameObject InventorySlot;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        range = Vector3.Distance(Player.position, transform.position);

        if (Physics.Raycast(ray, out hit) && range <= 4.5f)
        {
            if (Input.GetButtonDown("PickUp") && Wood.activeSelf == true)
            {
                Wood.SetActive(false);
                FakeWood.SetActive(true);
                InventorySlot.SetActive(false);
            }
        }
    }

}
