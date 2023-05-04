using UnityEngine;

public class CameraRotateAround : MonoBehaviour 
{
	private Transform target;
	private Vector3 offset;
	private float sensitivity = 3;
	private float limit = 50;
	private float zoom = 10f;
	private float zoomMax = 25;
	private float zoomMin = 1; 
	private float x, y;

	private void Start () 
	{
		target = GameObject.Find("Skull").transform;
		limit = Mathf.Abs(limit);
		if(limit > 90)
        {
			limit = 90;
		}

		offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax)/2);
		transform.position = target.position + offset;
	}

	private void Update ()
	{
		if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
			offset.z += zoom;
		}

		else if(Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
		offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));

		x = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
		y += Input.GetAxis("Mouse Y") * sensitivity;
		y = Mathf.Clamp (y, -limit, limit);
		transform.localEulerAngles = new Vector3(-y, x, 0);
		transform.position = transform.localRotation * offset + target.position;
	}
}