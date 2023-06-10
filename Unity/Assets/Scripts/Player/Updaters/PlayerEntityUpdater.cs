using System.Collections.Generic;
using Common;
using Core;
using Player.Updaters;

namespace Player
{
    public class PlayerEntityUpdater : IFrameUpdater, IFixedUpdater
    {
        private readonly PlayerEntity _playerEntity;
        private readonly GameData _gameData;
        private readonly CompositeUpdater _idleUpdater;
        public PlayerEntityUpdater(PlayerEntity playerEntity, GameData gameData, GameContent gameContent)
        {
            _idleUpdater = new CompositeUpdater(
                new List<IFrameUpdater>()
                {
                    new PlayerMovementInputUpdater(gameData.PlayerMovementInput),
                },
                new List<IFixedUpdater>()
                {
                    new PlayerMovementUpdater(playerEntity, gameData.PlayerMovementInput, gameContent.PlayerMovementConfig),
                }
            );
        }
        
        public void Update()
        {
            _idleUpdater.Update();
        }
        
        public void FixedUpdate()
        {
            _idleUpdater.FixedUpdate();
        }
    }
}