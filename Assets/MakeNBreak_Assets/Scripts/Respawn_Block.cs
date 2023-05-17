using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Block : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y < 0.4)
        {
            transform.position = new Vector3(0.243f, 1f, -0.301f);
        }
    }
}