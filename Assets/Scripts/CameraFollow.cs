using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Vector3 velocity = Vector3.zero;
    private Transform carTarget;
    [SerializeField] private float translationSpeed;
    [SerializeField] private float rotationSpeed;
    void FixedUpdate()
    {
        HandleTranslation();
        HandleRotation();
    }
    public void SetTarget(Transform target)
    {
        carTarget = target;
    }
    private void HandleTranslation()
    {
        var targetPosition = carTarget.TransformPoint(offset);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity,  translationSpeed * Time.deltaTime);
    }
    private void HandleRotation()
    {
        var direction = carTarget.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}
