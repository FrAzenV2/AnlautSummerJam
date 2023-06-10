using UnityEngine;

namespace Player
{
    public class PlayerEntity
    {

        public PlayerEntity(PlayerEntityView playerEntityView)
        {
            View = playerEntityView;
        }
        
        public PlayerEntityView View { get; }
        
        public Transform Transform => View.Transform;
    }
}