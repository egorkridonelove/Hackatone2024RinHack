using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class AuthDialog : MonoBehaviour
{

    [SerializeField] private YandexGame YG;
    
    public float timerDuration = 5f;

    void Start()
    {
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(timerDuration);
        YG._OpenAuthDialog();
    }
}
