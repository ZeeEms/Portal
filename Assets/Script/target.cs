using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool alive = true;

    public void Start()
    {
        
        currentHealth = maxHealth;
        alive = true;
    }
    public void Hit()
    {
        if (alive)
        {
            takeDamage(20);
            Debug.Log("Ouch");
            
        } 

    }

    public void takeDamage(int damage)
    {
        if (!alive)
        {
            return;
        }
        currentHealth -= damage;

        if( currentHealth <= 0)
        {
            currentHealth = 0;
            alive = false;
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Dead");

        //respawn
        StartCoroutine(RespawnAfterDelay(0.1f));
    }

    private IEnumerator RespawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        transform.position = new Vector3(54.41f, 2.72f, -16.67f);
        currentHealth = maxHealth;
        alive = true;
        Debug.Log("Respawned");
    }
}
