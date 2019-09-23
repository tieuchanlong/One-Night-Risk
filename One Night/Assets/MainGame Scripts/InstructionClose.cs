using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionClose : MonoBehaviour {

    public GameObject Instruction;
    public GameObject Instruction1;
    public GameObject Instruction2;

    void Update()
    {
        if (Input.GetButtonDown("PickUp"))
        {
            Instruction.SetActive(false);
            Instruction1.SetActive(false);
            Instruction2.SetActive(false);
        }    
    }
}
