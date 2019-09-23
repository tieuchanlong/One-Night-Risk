using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsManage : MonoBehaviour
{
    public GameObject InstructionPage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenInstruction()
    {
        InstructionPage.SetActive(true);
    }

    public void CloseInstruction()
    {
        InstructionPage.SetActive(false);
    }
}
