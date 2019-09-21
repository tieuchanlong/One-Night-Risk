using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrenchAttack : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            GetComponent<Animation>().Play("WrenchAnim");
        }
    }
}
