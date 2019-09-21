using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour {

    Light CeilingLight;

    private int count = 1;
    private int count1 = 0;
    private int Rand;

    public GameObject Doll;
    public GameObject Doll1;
    public GameObject Doll2;

    void Start()
    {
        CeilingLight = this.GetComponent<Light>();
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
            count++;

            if (count == 20)
            {
                Rand = Random.Range(1, 4);
                
                if (Rand == 0)
                {
                    Doll.SetActive(true);Doll1.SetActive(false);Doll2.SetActive(false);
                }
                else if (Rand == 1)
                {
                    Doll.SetActive(false); Doll1.SetActive(true); Doll2.SetActive(false);
                }
                else if (Rand == 2)
                {
                    Doll.SetActive(false); Doll1.SetActive(false); Doll2.SetActive(true);
                }
                else
                {
                    Doll.SetActive(false); Doll1.SetActive(false); Doll2.SetActive(false);
                }

                count = 0;
            }
        }
    }
}
