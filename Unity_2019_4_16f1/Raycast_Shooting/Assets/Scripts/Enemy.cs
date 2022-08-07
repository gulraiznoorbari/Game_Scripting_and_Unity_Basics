using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _health = 50f;

    public void TakeDamage(float damageAmount)
    {
        _health -= damageAmount;
        if (_health <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
