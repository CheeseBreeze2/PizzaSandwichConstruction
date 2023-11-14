using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWithSpoon : MonoBehaviour
{
    public Transform PizzaTeleportPoint; // Assign the teleport destination in the Inspector.
    public GameObject CharacterPlayer;             // Assign the player GameObject in the Inspector.
    public GameObject TeleportSpoon;              // Assign the spoon GameObject in the Inspector.

   

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SpoonTeleport"))
        {
            TeleportPlayer();
        }
    }
    private void TeleportPlayer()
    {
        // Ensure the teleport destination and player are set.
        if (PizzaTeleportPoint != null && CharacterPlayer != null)
        {
            // Teleport the player to the destination position.
            CharacterPlayer.transform.position = PizzaTeleportPoint.position;


        }
        else
        {
            // Log a warning if the teleport destination or player is not set.
            Debug.LogWarning("Teleport destination or player not set. Please assign them in the inspector.");
        }
    }
    private bool IsSpoonCollidingWithCylinder()
    {
        Debug.Log("Checking spoon-cylinder collision."); // Add this line to check if the collision check is executed.

        // Check if the spoon is colliding with the cylinder.
        Collider[] colliders = Physics.OverlapSphere(TeleportSpoon.transform.position, TeleportSpoon.GetComponent<SphereCollider>().radius);
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject == gameObject)
            {
                // The spoon is colliding with the cylinder.
                Debug.Log("Spoon is colliding with the cylinder!"); // Add this line to check if the collision is detected.
                return true;
            }
        }
        return false;
    }
}
