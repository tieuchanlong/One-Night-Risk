using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCamera1 : MonoBehaviour {

    public GameObject FadeScene;
    public GameObject Camera;
    public Transform Camera1;

    public static bool isActive = false;

    public AudioSource PanicBreathing;

    private Animation Clip;

    void Start()
    {
        Clip = Camera.GetComponent<Animation>();
    }

    void Update()
    {
        if (isActive == false && FadingScene.Clip_stop == true)
        {
            PanicBreathing.Play();
            Camera.GetComponent<Animation>().Play("EndingCamera1");
            isActive = true;
        }

        if (Clip.IsPlaying("EndingCamera1") == false && isActive == true)
        {
            Camera1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            PanicBreathing.Stop();
        }
    }

}
