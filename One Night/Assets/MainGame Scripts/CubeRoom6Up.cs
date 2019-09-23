using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRoom6Up : MonoBehaviour {

    public GameObject Marble;
    public GameObject Marble1;
    public GameObject Marble2;
    public GameObject Cube;

    private bool isActive = false;

    void Update()
    {
        if (Marble.activeSelf == true && Marble1.activeSelf == true && Marble2.activeSelf == true && isActive == false)
        {
            Cube.GetComponent<Animation>().Play("Room6_cube");
            isActive = true;
        }
    }
}
