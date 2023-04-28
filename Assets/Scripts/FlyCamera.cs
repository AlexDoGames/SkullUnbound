using UnityEngine;

public class FlyCamera : MonoBehaviour 
{
    public float CamSens = 0.25f;
    public GameObject Player;
    private Vector3 lastMousePos;

    void Awake()
    {
        lastMousePos = Player.transform.position;
    }
    void Update () 
    {

        lastMousePos = Input.mousePosition - lastMousePos;
        if (Input.GetMouseButton(0))
        {
            lastMousePos = new Vector3(-lastMousePos.y * CamSens, lastMousePos.x * CamSens, 0);
            lastMousePos = new Vector3(transform.eulerAngles.x + lastMousePos.x, transform.eulerAngles.y + lastMousePos.y, 0);
            transform.eulerAngles = lastMousePos;
            lastMousePos = Input.mousePosition;
        }
    }
}