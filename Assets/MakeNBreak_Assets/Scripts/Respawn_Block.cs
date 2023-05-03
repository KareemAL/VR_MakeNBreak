using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Block : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y < 0.4)
        {
            transform.position = new Vector3(-0.038f, 0.873f, 0.297f);
        }
    }
}