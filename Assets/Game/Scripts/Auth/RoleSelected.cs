using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class RoleSelected : MonoBehaviour
{

    public GameObject BirthPanel; 
    public GameObject ParentWarn; 
    public GameObject Cache;


    public void ClickOnKid()
    {
        StartCoroutine(Children());
    }

    public void ClickOnParent()
    {
        StartCoroutine(Parent());
    }

    private IEnumerator Children()
    {
        yield return new WaitForSeconds(0.2f);
        GlobalValues.role = 0;
        YandexGame.savesData._role = GlobalValues.role;
        BirthPanel.SetActive(true);
        Cache.SetActive(false);
    }

    private IEnumerator Parent()
    {
        yield return new WaitForSeconds(0.2f);
        GlobalValues.role = 1;
        YandexGame.savesData._role = GlobalValues.role;
        ParentWarn.SetActive(true);
        Cache.SetActive(false);
    }
}
