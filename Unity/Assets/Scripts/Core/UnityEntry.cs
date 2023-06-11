using Player.Models;
using Player.Views;
using UnityEngine;

namespace Core
{
    public class UnityEntry : MonoBehaviour
    {
        [SerializeField] private LocationInteractables _locationInteractables;
        [SerializeField] private GameContent _gameContent;
        [SerializeField] private PlayerEntityView _playerEntityView;
        private GameUpdater _gameUpdater;

        private void Start()
        {
            _gameUpdater = new GameUpdater(InitPlayer(), _gameContent, _locationInteractables);
        }

        private void Update()
        {
            _gameUpdater.Update();
        }

        private void FixedUpdate()
        {
            _gameUpdater.FixedUpdate();
        }

        private PlayerEntity InitPlayer()
        {
            return new PlayerEntity(_playerEntityView);
        }
    }
}