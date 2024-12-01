using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class SelectBirthday : MonoBehaviour
{
    public void EightYear()
    {
        GlobalValues.birth = 8;
        SaveIt();
    }
    public void NineYear()
    {
        GlobalValues.birth = 9;
        SaveIt();
    }
    public void TenYear()
    {
        GlobalValues.birth = 10;
        SaveIt();
    }
    public void ElevenYear()
    {
        GlobalValues.birth = 11;
        SaveIt();
    }
    public void TwelveYear()
    {
        GlobalValues.birth = 12;
        SaveIt();
    }
    public void ThirteenYear()
    {
        GlobalValues.birth = 13;
        SaveIt();
    }
    public void FourteenYear()
    {
        GlobalValues.birth = 14;
        SaveIt();
    }
    public void FifteenYear()
    {
        GlobalValues.birth = 15;
        SaveIt();
    }

    private void SaveIt()
    {
        YandexGame.savesData._birth = GlobalValues.birth;
    }
}
