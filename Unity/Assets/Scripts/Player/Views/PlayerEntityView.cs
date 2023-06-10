using UnityEngine;

namespace Player
{
    public class PlayerEntityView : MonoBehaviour
    {
        [field: SerializeField] public Rigidbody2D Rigidbody2D { get; private set; }
        public Transform Transform { get; private set; }
        private void Awake()
        {
            Transform = transform;
        }

    }
}