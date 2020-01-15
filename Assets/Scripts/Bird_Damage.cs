using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bird_Damage : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;

    public GameObject deatheffect;

    public void TakeDamage(int damage)

    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deatheffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
