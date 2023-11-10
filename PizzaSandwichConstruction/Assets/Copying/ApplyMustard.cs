using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyMustard : MonoBehaviour
{
    public GameObject Bread1;          // Reference to the regular bread prefab.
    public GameObject MustardBread;   // Reference to the bread with mustard prefab.

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("MustardApplicator"))
        {
            ApplyMustardToBread();
        }
    }

    void ApplyMustardToBread()
    {
        // Get the position and rotation of the current regular bread.
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        // Instantiate the bread with mustard at the same position and rotation.
        GameObject breadWithMustard = Instantiate(MustardBread, position, rotation);

        // Destroy the current regular bread object.
        Destroy(Bread1);
    }
}
