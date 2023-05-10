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
        // Set the offset distance in front of the plane's surface
        float offset = 0.01f;
        Vector3 rayOrigin = transform.position + transform.forward * offset;

        // Shoot a ray from the updated starting position
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward*1000, out hit))
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