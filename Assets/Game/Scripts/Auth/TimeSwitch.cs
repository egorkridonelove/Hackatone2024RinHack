using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSwitch : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;
    public float timerDuration = 5f;

    void Start()
    {
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(false);
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

        if (objectToEnable != null)
        {
            objectToEnable.SetActive(true);
        }
    }
}
