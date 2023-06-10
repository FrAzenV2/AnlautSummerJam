using System;
using Core;
using Player;
using UnityEngine;

public class UnityEntry : MonoBehaviour
{
    [SerializeField] private GameContent _gameContent;
    [SerializeField] private PlayerEntityView _playerEntityView;
    private GameUpdater _gameUpdater;
    
    void Start()
    {
        _gameUpdater = new GameUpdater(InitPlayer(), _gameContent);
    }

    private PlayerEntity InitPlayer()
    {
        return new PlayerEntity(_playerEntityView);
    }

    private void Update()
    {
        _gameUpdater.Update();
    }

    private void FixedUpdate()
    {
        _gameUpdater.FixedUpdate();
    }
}
