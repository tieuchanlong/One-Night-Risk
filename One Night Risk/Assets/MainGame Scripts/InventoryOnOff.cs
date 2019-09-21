using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryOnOff : MonoBehaviour {

    public GameObject Inventory;
    public GameObject PauseScreen;
    public GameObject Player;

    public static bool Active;
    private bool Active1;

    public GameObject SlotInfo;
    private GameObject child;

    private bool check;

    public GameObject HealthBar;

    void Start()
    {
        Active = false;
        Active1 = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Inventory") && PauseScreen.activeSelf == false)
        {
            if (Active == false)
            {
                Inventory.SetActive(true);
                Active = true;
            }
            else
            {
                Inventory.SetActive(false);
                Active = false;
            }
        }

        if (Input.GetKeyDown("p"))
        {
            if (Active1 == false)
            {
                PauseScreen.SetActive(true);
                Active1 = true;
            }
            else
            {
                PauseScreen.SetActive(false);
                Active1 = false;
            }
        }

        check = false;
        for (int i = 0; i < SlotInfo.transform.childCount; i++)
        {
            child = SlotInfo.transform.GetChild(i).gameObject;
            if (child.activeSelf == true)
            {
                Cursor.visible = true;
                Screen.lockCursor = false;
                Player.GetComponent<FirstPersonController>().enabled = false;
                check = true;
                break;
            }
        }


        if (Inventory.activeSelf == false && PauseScreen.activeSelf == false && check == false)
        {
            Cursor.visible = false;
            Screen.lockCursor = true;
            HealthBar.SetActive(true);
            Player.GetComponent<FirstPersonController>().enabled = true;
        }
        else
        {
            Cursor.visible = true;
            Screen.lockCursor = false;
            HealthBar.SetActive(false);
            Player.GetComponent<FirstPersonController>().enabled = false;
        }

    }
}
