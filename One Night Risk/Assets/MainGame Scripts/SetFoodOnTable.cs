using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFoodOnTable : MonoBehaviour
{

    private Ray ray;
    private RaycastHit hit;

    public GameObject Food;
    public GameObject SuspendedFood;

    void OnTriggerStay(Collider other)
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && other.CompareTag("Player"))
        {
            if (Input.GetButtonDown("PickUp") && Food.activeSelf == true && SuspendedFood.activeSelf == false)
            {
                SuspendedFood.SetActive(true);
            }
        }
    }
}
