using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class PythonCourse : MonoBehaviour
{
    /*
    0 - nope
    1 - star
    */
    public Sprite[] starstatus;


    public Image starl1;
    public Image starl2;
    public Image starl3;
    public Image starl4;
    public Image starl5;

    public GameObject locker1;
    public GameObject locker2;
    public GameObject locker3;
    public GameObject locker4;

    public void OnEnable()
    {
        YandexGame.LoadProgress();
        PythonInfoReset();
    }

    public void PythonInfoReset()
    {
        YandexGame.LoadProgress();
        if (YandexGame.savesData.p_l1 == true)
        {
            starl1.sprite = starstatus[1];
            locker1.SetActive(false);
        }
        if (YandexGame.savesData.p_l2 == true)
        {
            starl2.sprite = starstatus[1];
            locker2.SetActive(false);
        }
        if (YandexGame.savesData.p_l3 == true)
        {
            starl3.sprite = starstatus[1];
            locker3.SetActive(false);
        }
        if (YandexGame.savesData.p_l4 == true)
        {
            starl4.sprite = starstatus[1];
            locker4.SetActive(false);
        }
        if (YandexGame.savesData.p_l5 == true)
        {
            starl5.sprite = starstatus[1];
        }
    }
}
