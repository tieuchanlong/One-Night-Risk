using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRoom3Up : MonoBehaviour
{

    public GameObject Picture;
    public GameObject Picture1;
    public GameObject Picture2;
    public GameObject Cylinder;

    private bool isActive = false;

    void Update()
    {
        if (Picture.activeSelf == true && Picture1.activeSelf == true && Picture2.activeSelf == true && isActive == false)
        {
            Cylinder.GetComponent<Animation>().Play("Room3_cylinder");
            isActive = true;
        }    
    }

}
