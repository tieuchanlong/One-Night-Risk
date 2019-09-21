using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutWardrobe : MonoBehaviour
{

    private bool isActive = false;
    private float range;
    private bool Instruct_appear = false;

    private Ray ray;
    private RaycastHit hit;

    public Transform Player;

    public AudioSource SoundEffect;

    public GameObject Axe;
    public GameObject Cylinder;
    public GameObject InsideStuff;
    public GameObject Instruction;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        range = Vector3.Distance(Player.position, transform.position);

        if (range <= 6.0f && Physics.Raycast(ray, out hit) && Instruct_appear == false)
        {
            Instruction.SetActive(true);
            Instruct_appear = true;
        }

        if (Axe.activeSelf == true && range <= 5.0f  && Physics.Raycast(ray, out hit) && Input.GetButtonDown("Interact"))
        {
            Debug.Log("Hit");
            if (isActive == false)
            {
                Cylinder.GetComponent<Animation>().Play("DoorOpen");
                isActive = true;
                SoundEffect.Play();
                InsideStuff.SetActive(true);
            }
        }
    }

}
