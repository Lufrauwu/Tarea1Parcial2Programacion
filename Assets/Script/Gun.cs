using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private float _knocbackX = 1000f;
    private float _knocbackY = 300f;
    public Camera _mainCamera;
    void Update()
    {
        Shoot();
    }

    IEnumerator MovableObject(Transform enemies)
    {
        yield return enemies;
        enemies.GetComponent<Rigidbody>().AddForce(transform.forward *_knocbackX, ForceMode.Force);
        enemies.GetComponent<Rigidbody>().AddForce(transform.up * _knocbackY, ForceMode.Force);
    }

    private void Shoot()
    {
        Ray ray = _mainCamera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit objects;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out objects ))
            {
                StartCoroutine(MovableObject(objects.transform));
            }
        }
    }
    
 }
