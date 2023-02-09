using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private float _damage = 10f;
    [SerializeField] private float _range = 100f;
    [SerializeField] private float _impactForce = 50f;
    public float _fireRate = 15f; //greater fire rate less time between shots.

    [SerializeField] private Camera _fpscamera;
    [SerializeField] private ParticleSystem _muzzleFlash;
    [SerializeField] private ParticleSystem _impactEffect;

    private float nextTimetoFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) | (Input.GetButton("Fire1")) && Time.time >= nextTimetoFire)
        {
            nextTimetoFire = Time.time + 1f / _fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        _muzzleFlash.Play();
        RaycastHit hitInfo;
        if(Physics.Raycast(_fpscamera.transform.position, _fpscamera.transform.forward, out hitInfo, _range))
        {
            Debug.Log(hitInfo.transform.name);
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(_damage);
            }

            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(-hitInfo.normal * _impactForce);
            }

            ParticleSystem impact = Instantiate(_impactEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
            Destroy(impact, 2f);
        }
    }
}

