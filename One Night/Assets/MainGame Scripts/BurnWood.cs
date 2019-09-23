using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnWood : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;
    private float range;

    public Transform Player;
    public GameObject Lighter;
    public GameObject FakeWood;
    public GameObject Fire;

    public AudioSource SoundEffect;
    public AudioSource BackgroundMusic;


    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        range = Vector3.Distance(Player.position, transform.position);

        if (Physics.Raycast(ray, out hit) && range <= 4.5f)
        {
            if (Input.GetButtonDown("PickUp") && Lighter.activeSelf == true && FakeWood.activeSelf == true)
            {
                Fire.SetActive(true);
            }
        }

        if (range <= 4.5f && Fire.activeSelf == true)
        {
            HealthBar.scale += 0.5f;
            if (HealthBar.scale >= 100f)
            {
                HealthBar.scale = 100f;
            }

            BackgroundMusic.volume += 0.05f;
            SoundEffect.volume -= 0.05f;

            if (BackgroundMusic.volume >= 0.3f)
            {
                BackgroundMusic.volume = 0.3f;
            }

            if (SoundEffect.volume <= 0f)
            {
                SoundEffect.volume = 0f;
            }

        }

    }
}
