using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCell : MonoBehaviour
{
    public Material targetMaterial;
    private bool detected = false;

    public bool IsDetected()
    {
        return detected;
    }

    private void Update()
    {
        // Shoot a ray from the plane surface
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Renderer renderer = hit.transform.GetComponent<Renderer>();

            // Check if the hit object has a renderer and if the material matches the target material
            if (renderer != null && renderer.sharedMaterial == targetMaterial)
            {
                detected = true;
                Debug.Log("RayCast: True");
            }
            else
            {
                detected = false;
                Debug.Log("RayCast: False");
            }
        }
    }
}