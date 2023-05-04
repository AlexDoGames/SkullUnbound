using System.Collections;
using UnityEngine;

public class CorutineSample : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0.5f;
        Coroutine corutine = StartCoroutine(timer());
        //StopCoroutine(corutine);
    }
    private IEnumerator timer()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);
            yield return new WaitForSecondsRealtime(1);
            yield return null;
            Debug.Log(i);
        }

    }
}
