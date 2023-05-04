using UnityEngine;

public class GroundController : MonoBehaviour
{
    private GameObject ground;
    private GameObject groundNotion;
    
    private void Start()
    {
        ground = GetComponent<GameObject>();
        groundNotion = GetComponent<GameObject>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
            ground.GetComponent<Animator>().Play("GroundMoveAnimation");
    }

    private void OnTriggerEnter(Collider other)
    {
        groundNotion.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        groundNotion.SetActive(false);
    }
}
