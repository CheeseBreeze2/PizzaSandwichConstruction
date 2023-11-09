using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplacePizzaOnTouch : MonoBehaviour
{
    public GameObject PizzaDough; // Reference to the pizza dough.
    public GameObject PizzaDoughSauce; // Reference to the sauced pizza dough.

    private bool isReplaced = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "FreeSpoon")
        {
            // Replace pizza dough with sauced pizza dough.
            Destroy(PizzaDough);
            Instantiate(PizzaDoughSauce, transform.position, transform.rotation);
            isReplaced = true;
        }
    }
}
