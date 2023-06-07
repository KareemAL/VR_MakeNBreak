using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCell : MonoBehaviour
{
    public Material targetMaterial;
    public Material OwnMaterial;
    public bool IsEmpty;
    private bool detected = false;

    public bool IsDetected()
    {
        return detected;
    }

    private void Update()
    {
        Vector3 OffsetVector = new Vector3(0, 0, -1);
        // Set the offset distance in front of the plane's surface
        //Vector3 rayOrigin = transform.position + (transform.forward + OffsetVector);

        // Shoot a ray from the updated starting position
        RaycastHit hit;
        if (IsEmpty)        // set to true if nothing is hit
        {
            if (Physics.Raycast(transform.position, transform.up*1000, out hit))
            {
                detected = false;
                //Debug.Log("RayCast: False");
                OwnMaterial.color = Color.red;
            }
            else
            {
                detected = true;
                //Debug.Log("RayCast: True");
                OwnMaterial.color = Color.green;
            }
        }
        else                // set to true if correct mat is hit
        {
            if (Physics.Raycast(transform.position, transform.up*1000, out hit))
            {
                Renderer renderer = hit.transform.GetComponent<Renderer>();

                // Check if the hit object has a renderer and if the material matches the target material
                if (renderer != null && renderer.sharedMaterial == targetMaterial)
                {
                    detected = true;
                    //Debug.Log("RayCast: True");
                    OwnMaterial.color = Color.green;
                }
                else
                {
                    detected = false;
                    //Debug.Log("RayCast: False");
                    OwnMaterial.color = Color.red;
                }
            }
            else
            {
                detected = false;
                //Debug.Log("RayCast: False");
                OwnMaterial.color = Color.red;
            }
        }
    }
}