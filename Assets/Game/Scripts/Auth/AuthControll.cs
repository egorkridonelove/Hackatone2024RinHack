using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class AuthControll : MonoBehaviour
{
    public GameObject AuthPanel;
    public GameObject MenuPanel;
    public GameObject Background;
    public GameObject _ost;
    public float timerDuration = 5f;
    private bool authis;

    private void Start()
    {
        YandexGame.LoadProgress();
        authis = YandexGame.savesData._authorized;
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(timerDuration);

        if (authis == false)
        {
            AuthPanel.SetActive(true);
        }
        else
        {
            MenuPanel.SetActive(true);
            Background.SetActive(true);
            _ost.SetActive(true);
        }
    }
}
