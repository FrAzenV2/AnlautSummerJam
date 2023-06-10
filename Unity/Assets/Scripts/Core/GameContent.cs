using Items;
using Player.Configs;
using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "GameContent", menuName = "Configs/GameContent", order = 0)]
    public class GameContent : ScriptableObject
    {
        [field: SerializeField] public PlayerMovementConfig PlayerMovementConfig { get; private set; }
        [field: SerializeField] public ItemViewDescriptions ItemViewDescriptions { get; private set; }
    }
}