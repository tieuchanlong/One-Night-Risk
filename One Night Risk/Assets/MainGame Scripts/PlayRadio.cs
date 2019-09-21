using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRadio : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;
    private float range;

    public GameObject PartyPeople;
    public GameObject SeekingPeople;

    public Transform Player;

    public AudioSource Radio;

    private bool isActive = false;
    private bool Play = false;


    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        range = Vector3.Distance(Player.position, transform.position);

        if (Physics.Raycast(ray, out hit) && range <= 4.5f)
        {
            if (Input.GetButtonDown("PickUp"))
            {
                if (Play == false)
                {
                    Radio.Play();
                    Play = true;
                    isActive = false;
                }

                if (isActive == false && Play == true)
                {
                    Radio.volume = 0.5f;
                    isActive = true;

                    if (EntranceDoorOpen.PeopleAppear == true)
                    {
                        PartyPeople.SetActive(false);
                        SeekingPeople.SetActive(true);
                    }
                }
                else
                {
                    Radio.volume = 0f;
                    isActive = false;
                    if (EntranceDoorOpen.PeopleAppear == false)
                    {
                        PartyPeople.SetActive(true);
                        SeekingPeople.SetActive(false);
                    }
                }
            }
        }

    }
}
