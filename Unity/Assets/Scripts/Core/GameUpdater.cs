﻿using Common;
using Player.Models;
using Player.Updaters;

namespace Core
{
    public class GameUpdater : IFrameUpdater, IFixedUpdater
    {
        private readonly GameData _gameData;
        private readonly PlayerEntityUpdater _playerEntityUpdater;

        public GameUpdater(PlayerEntity playerEntity, GameContent gameContent)
        {
            _gameData = new GameData();
            _playerEntityUpdater = new PlayerEntityUpdater(playerEntity, _gameData, gameContent);
        }

        public void FixedUpdate()
        {
            _playerEntityUpdater.FixedUpdate();
        }

        public void Update()
        {
            _playerEntityUpdater.Update();
        }
    }
}