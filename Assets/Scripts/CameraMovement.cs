using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private GameObject _camera;

    private Vector3 offset;

    private void Start()
    {
        offset = _camera.transform.position - playerTransform.position;
    }

    private void FixedUpdate()
    { 
        _camera.transform.position = playerTransform.position + offset;   
    }
}
