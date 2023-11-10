using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color pink = Color.magenta; // Set the desired color in the Inspector.

    void Start()
    {
        // Call the ChangeObjectColor method to change the color.
        ChangeObjectColor(pink);
    }

    void ChangeObjectColor(Color color)
    {
        // Get the renderer component of the object.
        Renderer renderer = GetComponent<Renderer>();

        // Check if the object has a renderer.
        if (renderer != null)
        {
            // Create a new material to avoid modifying the shared material.
            Material material = new Material(renderer.material);

            // Set the color of the material.
            material.color = color;

            // Assign the new material to the renderer.
            renderer.material = material;
        }
        else
        {
            // Log a warning if the object doesn't have a renderer.
            Debug.LogWarning("Renderer component not found on the object.");
        }
    }
}
