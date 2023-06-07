using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Block : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y < 0.4)
        {
            transform.position = new Vector3(-0.4f, 0.95f, 0.13f);
        }
    }
}