using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    public GameObject Player;
    public GameObject Player1;

    private bool dead = false;

    public AudioSource DeadSound;

    void Update()
    {
        if (HealthBar.scale <= 0f && dead == false)
        {
            Player.GetComponent<Animation>().Play("DeathAnim");
            dead = true;
            Player1.GetComponent<FirstPersonController>().enabled = false;
            Screen.lockCursor = true;
            DeadSound.Play();
        }

        if (this.GetComponent<Animation>().IsPlaying("DeathAnim") == false && dead == true)
        {
            StartCoroutine(WaitTime());
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(1);
    }
}
