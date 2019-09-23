using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollAppear : MonoBehaviour {

    Light CeilingLight;
    public GameObject UpLight;

    private int count = 1;
    private int count1 = 0;
    private int Rand;

    public GameObject Doll;

    void Start()
    {
        CeilingLight = UpLight.GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            count1++;
            if (count1 <= 8 || count1 == 10)
            {
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                yield return new WaitForSeconds(2f);
            }

            if (count1 == 10)
            {
                count1 = 0;
            }
            CeilingLight.enabled = !CeilingLight.enabled;
            Doll.SetActive(true);
        }
    }
}
