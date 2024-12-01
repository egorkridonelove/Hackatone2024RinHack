using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class CourseManager : MonoBehaviour
{

    [SerializeField] private GameObject LockerCs;
    [SerializeField] private GameObject LockerDevOps;

    private void OnEnable()
    {
        if(YandexGame.savesData._birth > 11)
        {
            LockerCs.SetActive(false);
        }
        if(YandexGame.savesData._birth > 13)
        {
            LockerDevOps.SetActive(false);
        }
    }
}
