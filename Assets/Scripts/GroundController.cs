using UnityEngine;

public class GroundController : MonoBehaviour
{
    private GameObject ground;
    
    private void Start()
    {
        ground = GameObject.Find("MovingGround");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
            ground.GetComponent<Animator>().Play("GroundMoveAnimation");
    }
}
