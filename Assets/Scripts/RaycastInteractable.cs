using UnityEngine;

public class RaycastInteractable : MonoBehaviour
{
    [SerializeField]
    float _raycastDistance;

    [SerializeField]
    LayerMask _layerMask;

    [SerializeField]
    Transform _transformToRaycast;

    void Start()
    {
        
    }

    void Update()
    {
        if (_transformToRaycast == null)
        {
            return;
        }

        if (!Input.GetKeyDown(KeyCode.E))
        {
            return;
        }

        if (Physics.Raycast(origin: _transformToRaycast.position, direction: _transformToRaycast.forward, hitInfo: out RaycastHit hit, maxDistance: _raycastDistance, layerMask: _layerMask))
        {
            GameObject hitGO = hit.transform.gameObject;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(from: _transformToRaycast.position, to: _transformToRaycast.position + _transformToRaycast.forward * _raycastDistance);
    }
}
