using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class ClearPython : MonoBehaviour
{
    public void ClearL1()
    {
        if (YandexGame.savesData.p_l1 != true) { GlobalValues.stars += 1; GlobalValues.money += 15; GlobalValues.xp += 20; YandexGame.savesData._xp = GlobalValues.xp; YandexGame.savesData._money = GlobalValues.money; YandexGame.savesData._stars = GlobalValues.stars; YandexGame.savesData._money = GlobalValues.money;}
        YandexGame.savesData.p_l1 = true;
        YandexGame.savesData.p_s_l1 = 1;
        YandexGame.SaveProgress();
    }
    public void ClearL2()
    {
        if (YandexGame.savesData.p_l2 != true) { GlobalValues.stars += 1; GlobalValues.money += 15; GlobalValues.xp += 20; YandexGame.savesData._xp = GlobalValues.xp; YandexGame.savesData._money = GlobalValues.money; YandexGame.savesData._stars = GlobalValues.stars; YandexGame.savesData._money = GlobalValues.money;}
        YandexGame.savesData.p_l2 = true;
        YandexGame.savesData.p_s_l2 = 1;
        YandexGame.SaveProgress();
    }
    public void ClearL3()
    {
        YandexGame.savesData._stars = GlobalValues.stars;
        if (YandexGame.savesData.p_l3 != true) { GlobalValues.stars += 1; GlobalValues.money += 15; GlobalValues.xp += 20; YandexGame.savesData._xp = GlobalValues.xp; YandexGame.savesData._money = GlobalValues.money; YandexGame.savesData._stars = GlobalValues.stars; YandexGame.savesData._money = GlobalValues.money;}
        YandexGame.savesData.p_l3 = true;
        YandexGame.savesData.p_s_l3 = 1;
        YandexGame.SaveProgress();
    }
    public void ClearL4()
    {
        if (YandexGame.savesData.p_l4 != true) { GlobalValues.stars += 1; GlobalValues.money += 15; GlobalValues.xp += 20; YandexGame.savesData._xp = GlobalValues.xp; YandexGame.savesData._money = GlobalValues.money; YandexGame.savesData._stars = GlobalValues.stars; YandexGame.savesData._money = GlobalValues.money;}
        YandexGame.savesData.p_l4 = true;
        YandexGame.savesData.p_s_l4 = 1;
        YandexGame.SaveProgress();
    }
    public void ClearL5()
    {
        if (YandexGame.savesData.p_l5 != true) { GlobalValues.stars += 1; GlobalValues.money += 15; GlobalValues.xp += 20; YandexGame.savesData._xp = GlobalValues.xp; YandexGame.savesData._money = GlobalValues.money; YandexGame.savesData._stars = GlobalValues.stars; YandexGame.savesData._money = GlobalValues.money;}
        YandexGame.savesData.p_l5 = true;
        YandexGame.savesData.p_s_l5 = 1;
        YandexGame.SaveProgress();
    }
}
