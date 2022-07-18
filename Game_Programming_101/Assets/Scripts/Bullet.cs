using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody BulletRigidbody;
    public float Force = 3;

    public void Shoot(Vector3 direction)
    {
        BulletRigidbody.AddForce(direction.normalized * Force, ForceMode.Impulse);
    }
    private const string EnemyTag = "Enemy Tag";
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.LogError($"Cube : onCollisionEnter() with {collision.gameObject.name}");
        if (collision.gameObject.tag == EnemyTag)
        {
            // Any kind of aimations, particles or player behaviour will be written here.
            Debug.LogError("Object collided with Enemy!");
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        //Debug.LogError("Cube: onCollisionExit()");
    }
}
