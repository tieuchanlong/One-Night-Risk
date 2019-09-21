using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutPictureInFrame : MonoBehaviour
{

    private float range;

    public Transform Player;

    public GameObject Picture;
    public GameObject SuspendedPicture;
    public GameObject InventorySlot;

    void Update()
    {
        range = Vector3.Distance(Player.position, transform.position);
        if (Picture.activeSelf == true && range <= 10.0f && Input.GetButtonDown("PickUp"))
        {
            Picture.SetActive(false);
            SuspendedPicture.SetActive(true);
            InventorySlot.SetActive(false);
        }
    }

}
