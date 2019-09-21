using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ShowObjectInfo : MonoBehaviour
{
    public GameObject InfoPanel;
    public GameObject Inventory;

    public void OpenPanel()
    {
        InfoPanel.SetActive(true);
        Inventory.SetActive(false);
    }

}
