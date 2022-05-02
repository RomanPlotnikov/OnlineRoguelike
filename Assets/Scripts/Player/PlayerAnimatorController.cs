using UnityEngine;

namespace Player
{
    public class PlayerAnimatorController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private void Start()
        {
            _animator = GetComponentInChildren<Animator>();
        }

        private void OnEnable()
        {

        }

        private void OnDisable()
        {
            
        }

        private void ChangeAnimation(PlayerState playerState)
        {

        }
    }
}