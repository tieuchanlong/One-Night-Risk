using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCancel : MonoBehaviour
{

    public GameObject InfoPanel;
    public GameObject Inventory;

    public void ClosePanel()
    {
        InfoPanel.SetActive(false);
        Inventory.SetActive(true);
    }
}
