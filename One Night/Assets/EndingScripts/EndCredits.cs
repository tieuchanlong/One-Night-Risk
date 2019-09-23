using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour {

    public GameObject Text;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject FadeScene;
    public GameObject Room;
    public GameObject Camera;

    public string newGameLevel;

    private int isActive = -1;

    void Update()
    {
        if (Camera.GetComponent<Animation>().IsPlaying("EndingCamera2") == false && EndingCamera2.isActive == true && isActive == -1)
        {
            FadeScene.SetActive(true);
            FadeScene.GetComponent<Animation>().Play("ReverseFadingScreen");
            isActive = 0;
        }

        if (FadeScene.GetComponent<Animation>().IsPlaying("ReverseFadingScreen") == false && isActive == 0)
        {
            Text.SetActive(true);
            Room.SetActive(false);
            Text.GetComponent<Animation>().Play("TextAppear");
            isActive = 1;
        }    

        if (Text.GetComponent<Animation>().IsPlaying("TextAppear") == false && isActive == 1)
        {
            Text.SetActive(false);
            Text1.SetActive(true);
            Text1.GetComponent<Animation>().Play("Text1Appear");
            isActive = 2;
        }

        if (Text1.GetComponent<Animation>().IsPlaying("Text1Appear") == false && isActive == 2)
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
            Text2.GetComponent<Animation>().Play("Text2Appear");
            isActive = 3;
        }

        if (Text2.GetComponent<Animation>().IsPlaying("Text2Appear") == false && isActive == 3)
        {
            LoadMenu();
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
