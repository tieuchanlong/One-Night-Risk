using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutWall : MonoBehaviour
{

    private bool isActive = false;
    private float range;

    public Transform Player;

    public GameObject Wrench;
    public GameObject Picture;
    public GameObject InsideStuff;
    public GameObject Instruction;

    private bool active = false;

    void Update()
    {
        range = Vector3.Distance(Player.position, transform.position);
        if (range <= 5.0f)
        {
            if (Input.GetButtonDown("Interact") && Wrench.activeSelf == true)
            {
                if (isActive == false)
                {
                    Picture.SetActive(false);
                    isActive = true;
                    InsideStuff.SetActive(true);
                }
            }
            else
            {
                if (active == false)
                {
                    Instruction.SetActive(true);
                    active = true;
                }
            }
        }
    }

}
