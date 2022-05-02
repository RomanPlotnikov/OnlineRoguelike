using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private InputControlScheme _inputAction;

        private void Start()
        {
            _rigidbody = GetComponentInChildren<Rigidbody2D>();
        }

        private void OnEnable()
        { 

        }

        private void OnDisable()
        {

        }

        private void MoveTo(Vector2 direcion)
        {
           _rigidbody.MovePosition(direcion);
        }
    }
}
