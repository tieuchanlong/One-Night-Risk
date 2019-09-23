using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAxeInfo : MonoBehaviour
{
    public GameObject InfoPanel;
    public GameObject Inventory;

    public void OpenPanel()
    {
        InfoPanel.SetActive(true);
        Inventory.SetActive(false);
    }
}
