using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class DrinkWhiskey : MonoBehaviour
{

    public GameObject InfoPanel;
    public GameObject Player;

    public void EquipObject()
    {
        InfoPanel.SetActive(false);
        Player.GetComponent<FirstPersonController>().enabled = true;
        HealthBar.scale = 100f;
    }

}
