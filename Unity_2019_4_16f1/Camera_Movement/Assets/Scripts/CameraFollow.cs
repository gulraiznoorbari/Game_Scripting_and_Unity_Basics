using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float _smoothSpeed = 0.125f;
    [SerializeField] private Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private float _smoothTime = 0.3f;

    // LateUpdate is called after Update each frame
    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        // Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);
        // you can use Vector3.SmoothDamp() for dealing with jitters during motion.
        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, _smoothTime);
        transform.position = smoothPosition;

        transform.LookAt(target);
    }
}
