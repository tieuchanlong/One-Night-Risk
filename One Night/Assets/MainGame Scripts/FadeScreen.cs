using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class FadeScreen : MonoBehaviour {

    public GameObject FadeScene;
    public GameObject Player;

    public GameObject Health;

    private bool isActive = false;
    public static bool ingame = false;

    private Animation Clip;

    void Start()
    {
        Clip = FadeScene.GetComponent<Animation>();
        Health.SetActive(false);
        HealthBar.scale = 100f;
    }

    void Update()
    {
        if (isActive == false)
        {
            FadeScene.GetComponent<Animation>().Play("FadingScreenInGame");
            isActive = true;
        }

        if (Clip.IsPlaying("FadingScreenInGame") == true)
        {
            Player.GetComponent<FirstPersonController>().enabled = false;
        }

        if (Clip.IsPlaying("FadingScreenInGame") == false && isActive == true)
        {
            Health.SetActive(true);
            FadeScene.SetActive(false);
            Player.GetComponent<FirstPersonController>().enabled = true;
            ingame = true;
        }
    }
}
