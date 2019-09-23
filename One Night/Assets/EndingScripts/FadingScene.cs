using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingScene : MonoBehaviour {

    public GameObject FadeScene;

    private bool isActive = false;
    public static bool Clip_stop = false;

    private Animation Clip;

    void Start()
    {
        Clip = FadeScene.GetComponent<Animation>();
    }

    void Update()
    {
        if (isActive == false)
        {
            FadeScene.GetComponent<Animation>().Play("FadingScreen");
            isActive = true;
        }  
        
        if (Clip.IsPlaying("FadingScreen") == false && isActive == true)
        {
            FadeScene.SetActive(false);
            Clip_stop = true;
        }
    }

}
