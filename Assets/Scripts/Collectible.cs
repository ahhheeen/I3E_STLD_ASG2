using UnityEngine;
using StarterAssets;

public class Collectible : MonoBehaviour
{
    public virtual void Collected(GameObject player)
    {
        // Base implementation (can be empty)
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collected(other.gameObject);
        }
    }
}

public class SpeedCollectible : Collectible
{
    public float speedIncreaseAmount = 2.0f;  // Amount to increase speed

    public override void Collected(GameObject player)
    {
        FirstPersonController controller = player.GetComponent<FirstPersonController>();

        if (controller != null)
        {
            // Increase player's movement speed
            controller.MoveSpeed += speedIncreaseAmount;
        }

        // Destroy the collectible after collection
        Destroy(gameObject);
    }
}

public class JumpCollectible : Collectible
{
    public float jumpHeightIncreaseAmount = 2.0f;  // Amount to increase jump height

    public override void Collected(GameObject player)
    {
        FirstPersonController controller = player.GetComponent<FirstPersonController>();

        if (controller != null)
        {
            // Increase player's jump height
            controller.JumpHeight += jumpHeightIncreaseAmount;
        }

        // Destroy the collectible after collection
        Destroy(gameObject);
    }
}
