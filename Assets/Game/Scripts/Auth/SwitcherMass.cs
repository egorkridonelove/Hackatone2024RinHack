using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherMass : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject[] objectsToEnable;
    public float timerDuration = 5f;

    void Start()
    {
        foreach (GameObject obj in objectsToEnable)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }

        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(timerDuration);

        if (objectToDisable != null)
        {
            objectToDisable.SetActive(false);
        }

        foreach (GameObject obj in objectsToEnable)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }
}
