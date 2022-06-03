using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController = default;
    [SerializeField] private Vector3 _playerVelocity = default;
    [SerializeField] private float _speed = 5f;

    void Update()
    {

        float _zAxis = Input.GetAxis("Vertical");
        float _xAxis = Input.GetAxis("Horizontal");
        Vector3 move = transform.right * _xAxis + transform.forward * _zAxis;
        _characterController.Move(move * Time.deltaTime * _speed);

        
    }
    
}
