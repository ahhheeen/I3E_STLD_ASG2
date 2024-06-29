using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f; // Maximum health
    private float currentHealth; // Current health

    private void Start()
    {
        currentHealth = maxHealth; // Initialize health
    }

    // Method to take damage
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth); // Ensure health doesn't go below 0
        CheckPlayerDeath();
    }

    // Method to heal (optional)
    public void Heal(float healAmount)
    {
        currentHealth += healAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
    }

    // Check if the player is dead
    private void CheckPlayerDeath()
    {
        if (currentHealth <= 0f)
        {
            // Handle player death (e.g., respawn, game over screen)
            Debug.Log("Player has died!");
        }
    }
}

