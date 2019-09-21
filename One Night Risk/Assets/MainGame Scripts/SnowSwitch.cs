using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class SnowSwitch : MonoBehaviour {

    public Transform Player;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Health;
    public GameObject FadeScene;
    public GameObject FullBlack;

    public string newGameLevel;

    public AudioSource BreathingHard;

    private Animation End;

    private bool played = false;

    void Start()
    {
        End = Player2.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        SnowMonitor.OnSnow = 1;
    }

    void Update()
    {
        if (SnowMonitor.OnSnow == 1 && played == false)
        {
            played = true;
            Player.transform.position = new Vector3(140.67f, 3.26f, 168.71f);
            Player.transform.eulerAngles = new Vector3(-1.41f, -89.547f, 0.724f);
            Health.SetActive(false);
            Player2.GetComponent<Animation>().Play("Ending");
        }

        if (End.IsPlaying("Ending") == false && SnowMonitor.OnSnow == 1)
        {
            BreathingHard.volume -= 0.002f;
            FullBlack.SetActive(true);
            LoadEnd();
        } 

        if (End.IsPlaying("Ending") == true)
        {
            Health.SetActive(false);
        }

        /*if (FadeScene.GetComponent<Animation>().IsPlaying("ReverseFadingScreenInGame") == false && BreathingHard.volume <= 0f)
        {
            LoadEnd();
        }
        */
    }

    public void LoadEnd()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
