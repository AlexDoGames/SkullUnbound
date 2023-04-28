using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Player;

    void Update()
    {
        transform.position = Player.position;
    }
}
