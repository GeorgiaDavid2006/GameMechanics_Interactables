using UnityEngine;

public class PhysicsCube : MonoBehaviour
{
    Rigidbody _cubeRb;
    float _upForceOnInteract;
    void Awake()
    {
        _cubeRb = GetComponent<Rigidbody>();
    }

    void Reset()
    {
        _upForceOnInteract = 110;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void Interact()
    {
        if (_cubeRb == null)
        {
            _cubeRb.AddForce(Vector3.up * _upForceOnInteract);
        }
    }
}
