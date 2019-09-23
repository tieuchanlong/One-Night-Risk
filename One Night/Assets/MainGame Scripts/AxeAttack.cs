using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeAttack : MonoBehaviour
{

	void Update ()
    {
		if (Input.GetButtonDown("Interact"))
        {
            GetComponent<Animation>().Play("AxeAnim");
        }
	}
}
