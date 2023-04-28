using UnityEngine;

public class GroundController : MonoBehaviour
{
    public GameObject Ground;
    public GameObject GroundNotion;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
            Ground.GetComponent<Animator>().Play("GroundMoveAnimation");
    }

    private void OnTriggerEnter(Collider other)
    {
        GroundNotion.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        GroundNotion.SetActive(false);
    }
}
