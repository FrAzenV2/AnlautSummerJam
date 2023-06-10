using Player.Views;
using UnityEngine;

namespace Player.Models
{
    public class PlayerEntity
    {
        public PlayerEntity(PlayerEntityView playerEntityView)
        {
            View = playerEntityView;
        }

        public PlayerInventoryModel Inventory { get; } = new();
        public PlayerEntityView View { get; }
        
    }
}