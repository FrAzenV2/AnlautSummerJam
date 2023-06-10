using Common;
using Player.Configs;
using Player.Models;
using UnityEngine;

namespace Player.Updaters
{
    public class PlayerMovementUpdater : IFixedUpdater
    {
        private readonly PlayerMovementConfig _movementConfig;
        private readonly PlayerMovementInput _movementInput;
        private readonly PlayerEntity _playerEntity;

        private float _currentVelocity;

        public PlayerMovementUpdater(PlayerEntity playerEntity, PlayerMovementInput movementInput, PlayerMovementConfig movementConfig)
        {
            _playerEntity = playerEntity;
            _movementInput = movementInput;
            _movementConfig = movementConfig;
        }

        public void FixedUpdate()
        {
            _currentVelocity = Mathf.MoveTowards(_currentVelocity, _movementInput.Direction * _movementConfig.MaxMovementSpeed, _movementConfig.Acceleration * Time.fixedDeltaTime);
            _playerEntity.View.Rigidbody2D.velocity = new Vector2(_currentVelocity, _playerEntity.View.Rigidbody2D.velocity.y);
            _movementInput.Direction = 0;
        }
    }
}