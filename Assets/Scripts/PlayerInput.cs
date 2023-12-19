using UnityEngine;

namespace WildBoll.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMovement _playerMovement;
        private Vector3 movement;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXES);
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXES);

            movement = new Vector3(-vertical,0,  horizontal).normalized;
        }

        private void FixedUpdate()
        {
            _playerMovement.MoveCharacter(movement);
        }
    } 
}

