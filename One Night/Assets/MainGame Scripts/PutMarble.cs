using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutMarble : MonoBehaviour {

    private float range;

    public Transform Player;

    public GameObject Marble;
    public GameObject SuspendedMarble;
    public GameObject InventorySlot;

    void Update()
    {
        range = Vector3.Distance(Player.position, transform.position);
        if (Marble.activeSelf == true && range <= 5.0f && Input.GetButtonDown("PickUp"))
        {
            Marble.SetActive(false);
            SuspendedMarble.SetActive(true);
            InventorySlot.SetActive(false);
        }
    }
}
