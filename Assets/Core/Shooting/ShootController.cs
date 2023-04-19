using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public Bullet bullet;
    public Transform spawnTransform;

    // Start is called before the first frame update
    public void FireBullet()
    {
        Instantiate(bullet, spawnTransform.position, spawnTransform.rotation);
    }
}
