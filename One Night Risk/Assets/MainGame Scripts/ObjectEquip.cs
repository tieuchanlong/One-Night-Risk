using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ObjectEquip : MonoBehaviour
{

    public GameObject InfoPanel;
    public GameObject Object;
    public GameObject Equipment;
    private GameObject child;
    public GameObject Player;

    public void EquipObject()
    {
        InfoPanel.SetActive(false);
        for (int i = 0;i < Equipment.transform.childCount; i++)
        {
            child = Equipment.transform.GetChild(i).gameObject;
            child.SetActive(false);
        }
        Object.SetActive(true);
        Cursor.visible = false;
        Screen.lockCursor = true;
        Player.GetComponent<FirstPersonController>().enabled = true;
    }

}
