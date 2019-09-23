using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionOnOff : MonoBehaviour {

    public GameObject Scene;
    public GameObject Menu;
    public GameObject Instruction;

    public void OpenInstruction()
    {
        Scene.SetActive(false);
        Menu.SetActive(false);
        Instruction.SetActive(true);
    }

    public void CloseInstruction()
    {
        Scene.SetActive(true);
        Menu.SetActive(true);
        Instruction.SetActive(false);
    }
}
