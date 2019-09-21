using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public Light flashLight;
    private bool isActive;

    public AudioSource SoundEffect;

    void Start()
    {
        isActive = false;    
    }

    void Update ()
    {
		if (Input.GetButtonDown("Light"))
        {
            //Debug.Log("Light!");
            if (isActive == false)
            {
                flashLight.enabled = true;
                isActive = true;
                SoundEffect.Play();
            }
            else
            {
                flashLight.enabled = false;
                isActive = false;
                SoundEffect.Play();
            }
        }
	}
}
