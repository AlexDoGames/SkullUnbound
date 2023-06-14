using UnityEngine;

public class SkyRotation : MonoBehaviour
{
    private float speed = 2f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * speed);
    }
}
