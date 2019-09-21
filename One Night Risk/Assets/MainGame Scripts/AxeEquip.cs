using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeEquip : MonoBehaviour {

    public GameObject InfoPanel;
    public GameObject Axe;
    public GameObject Equipment;

    public void EquipAxe()
    {
        InfoPanel.SetActive(false);
        Axe.SetActive(true);
        Equipment.SetActive(false);
    }
}
