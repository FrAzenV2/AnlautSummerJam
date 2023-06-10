using System.Collections.Generic;
using Common;
using Core;
using Player.Models;

namespace Player.Updaters
{
    public class PlayerEntityUpdater : IFrameUpdater, IFixedUpdater
    {
        private readonly GameData _gameData;
        private readonly CompositeUpdater _idleUpdater;
        private readonly PlayerEntity _playerEntity;
        public PlayerEntityUpdater(PlayerEntity playerEntity, GameData gameData, GameContent gameContent)
        {
            _idleUpdater = new CompositeUpdater(
                new List<IFrameUpdater>
                {
                    new PlayerMovementInputUpdater(gameData.PlayerMovementInput)
                },
                new List<IFixedUpdater>
                {
                    new PlayerMovementUpdater(playerEntity, gameData.PlayerMovementInput, gameContent.PlayerMovementConfig)
                }
            );
        }

        public void FixedUpdate()
        {
            _idleUpdater.FixedUpdate();
        }

        public void Update()
        {
            _idleUpdater.Update();
        }
    }
}