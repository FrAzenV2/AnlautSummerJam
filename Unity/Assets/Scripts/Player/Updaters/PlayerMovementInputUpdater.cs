using Common;
using Player.Models;
using UnityEngine;

namespace Player.Updaters
{
    public class PlayerMovementInputUpdater : IFrameUpdater
    {
        private readonly PlayerMovementInput _input;

        public PlayerMovementInputUpdater(PlayerMovementInput input)
        {
            _input = input;
        }

        public void Update()
        {
            if (Input.GetKey(KeyCode.D)) _input.Direction = 1;
            if (Input.GetKey(KeyCode.A)) _input.Direction = -1;
        }
    }
}