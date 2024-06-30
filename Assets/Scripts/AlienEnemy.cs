using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienEnemy : MonoBehaviour
{
    public Transform player; // Reference to the player (assign in the Inspector)
    public float detectionRadius = 5f; // Distance to detect the player
    public float attackRadius = 2f; // Distance to start attacking

    private Animator animator;
    private bool isAttacking = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackRadius)
        {
            // Player is close enough to attack
            Attack();
        }
        else if (distanceToPlayer <= detectionRadius)
        {
            // Player is nearby, walk towards them
            WalkTowardsPlayer();
        }
        else
        {
            // Player is not near, idle
            Idle();
        }
    }

    private void Idle()
    {
        animator.SetBool("IsWalking", false);
        animator.SetBool("IsAttacking", false);
        // Add any other idle behavior (e.g., looking around)
    }

    public void WalkTowardsPlayer()
    {
        animator.SetBool("IsWalking", true);
        animator.SetBool("IsAttacking", false);
        // Move towards the player using NavMesh or other movement logic
        // Example: transform.LookAt(player); // Rotate to face the player
        // Example: Move towards player using transform.Translate or NavMeshAgent
    }

    private void Attack()
    {
        animator.SetBool("IsWalking", false);
        animator.SetBool("IsAttacking", true);
        // Implement attack logic (e.g., deal damage to player)
    }
}

