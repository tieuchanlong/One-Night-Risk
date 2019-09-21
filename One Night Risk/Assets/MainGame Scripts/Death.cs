using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Death : MonoBehaviour {

    public GameObject Player;
    public GameObject Player1;

    private bool dead = false;

    void Update()
    {
        if (HealthBar.scale <= 0f && dead == false)
        {
            Player.GetComponent<Animation>().Play("DeathAnim");
            dead = true;
            Player1.GetComponent<FirstPersonController>().enabled = false;
        }   
        
        if (Input.GetButtonDown("Open") && dead == true)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
