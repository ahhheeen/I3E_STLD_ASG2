using UnityEngine;
using StarterAssets;

public enum CollectibleType
{
    Speed,
    Jump
}

public class Collectible : MonoBehaviour
{
    public CollectibleType collectibleType;

    public float speedIncreaseAmount = 2.0f;  // Amount to increase speed
    public float jumpHeightIncreaseAmount = 2.0f;  // Amount to increase jump height

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FirstPersonController controller = other.GetComponent<FirstPersonController>();

            if (controller != null)
            {
                switch (collectibleType)
                {
                    case CollectibleType.Speed:
                        controller.MoveSpeed += speedIncreaseAmount;
                        break;
                    case CollectibleType.Jump:
                        controller.JumpHeight += jumpHeightIncreaseAmount;
                        break;
                }
            }

            Destroy(gameObject); // Destroy the collectible after collection
        }
    }
}
