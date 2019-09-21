using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image Health;
    public static float scale;
    public AudioSource SoundEffect;
    public AudioSource BackgroundMusic;

    public GameObject Inventory;
    public GameObject PauseScreen;

    void Start()
    {
        Health = GetComponent<Image>();
        scale = 100f;
    }

    void Update()
    {
        Health.fillAmount = scale / 100f;

        if (FadeScreen.ingame == true && Inventory.activeSelf == false && PauseScreen.activeSelf == false)
        {
            scale = scale - 0.02f;
        }


        if (scale <= 0f)
        {
            scale = 0f;
        }

        if (scale <= 30f)
        {

            if (SoundEffect.isPlaying == false && MannequinAttack.bleeding == false)
            {
                SoundEffect.Play();
            }
            
            BackgroundMusic.volume -= 0.02f;
            SoundEffect.volume += 0.02f;

            if (BackgroundMusic.volume <= 0.05f)
            {
                BackgroundMusic.volume = 0.05f;
            }

            if (SoundEffect.volume >= 0.5f)
            {
                SoundEffect.volume = 0.5f;
            }
        }

        if (scale > 30f)
        {
            SoundEffect.Stop();
        }
    }
}
