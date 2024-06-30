using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // References to other components (assign in the Inspector)
    public AcidPool acidPool;
    public AlienEnemy alienEnemy;
    public PlayerHealth playerHealth;

    private void Update()
    {
        // Example: Check if the player is near the acid pool
        if (IsNearAcidPool())
        {
            acidPool.TakeDamage(Time.deltaTime * acidPool.damagePerSecond);
        }

        // Example: Check if the player is near the alien enemy
        if (IsNearAlienEnemy())
        {
            alienEnemy.WalkTowardsPlayer();
        }
    }

    private bool IsNearAcidPool()
    {
        // Implement your logic to check proximity to acid pool
        // Return true if the player is near the acid pool
        return false; // Replace with your actual condition
    }

    private bool IsNearAlienEnemy()
    {
        // Implement your logic to check proximity to alien enemy
        // Return true if the player is near the alien enemy
        return false; // Replace with your actual condition
    }
}
