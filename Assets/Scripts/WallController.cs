using UnityEngine;

public class WallController : MonoBehaviour
{
    public GameObject Wall;
    public GameObject WallNotion;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
            Wall.GetComponent<Animator>().Play("WallAnimation");
    }

    private void OnTriggerEnter(Collider other)
    {
        WallNotion.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        WallNotion.SetActive(false);
    }
}
