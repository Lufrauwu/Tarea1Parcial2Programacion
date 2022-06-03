using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    [Range(1, 1000)]
    [SerializeField] private float _horizontalSensitivity = default;
    [Range(1, 1000)]
    [SerializeField] private float _verticalSensitivity = default;
    [SerializeField] private Transform _playerTransform = default;
    private float _xRotation = 0.0f;
    [SerializeField] private float _mouseX = default;
    [SerializeField] private float _mouseY = default;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
         AxisSet();
         transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _playerTransform.Rotate(Vector3.up * _mouseX);
    }

    private void AxisSet()
    {
         _mouseX = Input.GetAxis("Mouse X") * _horizontalSensitivity * Time.deltaTime;
         _mouseY = Input.GetAxis("Mouse Y") * _verticalSensitivity * Time.deltaTime;
         _xRotation -= _mouseY;
         _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
    }
}
