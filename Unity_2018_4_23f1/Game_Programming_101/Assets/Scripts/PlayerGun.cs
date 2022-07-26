using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public Bullet Bullet;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SpawnBullet();
        }
    }

    private void SpawnBullet()
    {
        var bullet = Instantiate(Bullet, transform);
        bullet.Shoot(transform.forward);
    }
}
