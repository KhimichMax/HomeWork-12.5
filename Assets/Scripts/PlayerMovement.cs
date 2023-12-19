using UnityEngine;

namespace WildBoll.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float _speed = 4f;
        
        private Rigidbody playerRigidbody;
        
        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }
        
        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * _speed);
        }
#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValueSpeed()
        {
            _speed = 4;
        }
#endif
    }
}

