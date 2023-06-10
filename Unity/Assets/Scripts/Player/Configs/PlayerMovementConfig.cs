using UnityEngine;

namespace Player.Configs
{
    [CreateAssetMenu(fileName = "PlayerMovementConfig", menuName = "Configs/PlayerMovement", order = 0)]
    public class PlayerMovementConfig : ScriptableObject
    {
        [field: SerializeField] public float MaxMovementSpeed { get; private set; } = 5f;
        [field: SerializeField] public float Acceleration { get; private set; } = 10f;
    }
}