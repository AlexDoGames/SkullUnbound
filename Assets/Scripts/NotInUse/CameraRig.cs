using UnityEngine;

public class CameraRig : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private float smoothTime = 1.5f;

    private Vector3 vel;
    public Transform cam;

    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, character.position, ref vel, smoothTime);
        transform.forward = Vector3.SmoothDamp(transform.forward, character.forward, ref vel, smoothTime);
        cam.transform.LookAt(character.position);
    }
}
