using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Player
{
    public class InputListener : MonoBehaviour
    {
        private Vector2 _direction;
        private PlayerController _playerController;
        private Rigidbody2D _rb;

        void Update()
        {
            float axisX = Input.GetAxis("Horizontal");
            float axisY = Input.GetAxis("Vertical");
            _direction = new Vector2(axisX, axisY);

            _playerController.Move(_direction, _rb);
            _playerController.Attack();
        }
        
        [Inject]
        public void Construct(PlayerController playerController, Rigidbody2D playerRb)
        {
            _playerController = playerController;
            _rb = playerRb;
        }
    }
}