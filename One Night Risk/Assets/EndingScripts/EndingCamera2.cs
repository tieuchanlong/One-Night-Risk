using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCamera2 : MonoBehaviour {

    public GameObject Camera;

    public static bool isActive = false;
    private bool song = false;

    public AudioSource ClockSound;
    public AudioSource EndingSong;

    private Animation Clip;

    void Start()
    {
        Clip = Camera.GetComponent<Animation>();
    }

    void Update()
    {
        if (isActive == false && Camera.GetComponent<Animation>().IsPlaying("EndingCamera1") == false && EndingCamera1.isActive == true)
        {
            ClockSound.Play();
            Camera.GetComponent<Animation>().Play("EndingCamera2");
            isActive = true;
        }

        if (Clip.IsPlaying("EndingCamera2") == true)
        {
            ClockSound.volume -= 0.0008f;
        }

        if (ClockSound.volume <= 0f && song == false)
        {
            ClockSound.Stop();
            EndingSong.Play();
            song = true;
        }

    }
}
