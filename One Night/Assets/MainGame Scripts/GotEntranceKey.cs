using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotEntranceKey : MonoBehaviour {

    public GameObject InventorySlot;
    public GameObject TalkingMannequin;

    void Update ()
    {
		if (InventorySlot.activeSelf == true)
        {
            TalkingMannequin.SetActive(true);
        }
	}
}
