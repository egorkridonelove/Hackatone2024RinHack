using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ShopManager : MonoBehaviour
{
public AudioSource buyaudio;
public Sprite[] sprites;
public Image avatarimg;
public Text moneyTitle;

public Text[] selector;

private void OnEnable()
{
    UpdateSelectorTexts();
    UpdateSkin();
}

private void UpdateSkin()
{
    if (YandexGame.savesData.av1)
    {
        avatarimg.sprite = sprites[0];
    }
    if (YandexGame.savesData.av2)
    {
        avatarimg.sprite = sprites[1];
    }
    if (YandexGame.savesData.av3)
    {
        avatarimg.sprite = sprites[2];
    }
    if (YandexGame.savesData.av4)
    {
        avatarimg.sprite = sprites[4];
    }
}

private void UpdateSelectorTexts()
{
    for (int i = 0; i < selector.Length; i++)
    {
        if ((i == 0 && YandexGame.savesData.av1) || 
            (i == 1 && YandexGame.savesData.av2) || 
            (i == 2 && YandexGame.savesData.av3) || 
            (i == 3 && YandexGame.savesData.av4))
        {
            selector[i].text = "Куплено";
        }
        else
        {
            selector[i].text = "Купить";
        }
    }
}

public void BuyAv1()
{
    if (!YandexGame.savesData.av1)
    {
        if (GlobalValues.money >= 100)
        {
            buyaudio.Play();
            GlobalValues.money -= 100;
            GlobalValues.skinid = 1;
            YandexGame.savesData._money = GlobalValues.money;
            YandexGame.savesData._avatarid = GlobalValues.skinid;
            moneyTitle.text = "Монет: " + GlobalValues.money;
            avatarimg.sprite = sprites[0];
            GlobalValues.av1 = true;
            YandexGame.savesData.av1 = GlobalValues.av1;
            YandexGame.SaveProgress();
            UpdateSelectorTexts();
        }
    }
}

public void BuyAv2()
{
    if (!YandexGame.savesData.av2)
    {
        if (GlobalValues.money >= 200)
        {
            buyaudio.Play();
            GlobalValues.money -= 200;
            GlobalValues.skinid = 2;
            YandexGame.savesData._money = GlobalValues.money;
            YandexGame.savesData._avatarid = GlobalValues.skinid;
            moneyTitle.text = "Монет: " + GlobalValues.money;
            avatarimg.sprite = sprites[1];
            GlobalValues.av2 = true;
            YandexGame.savesData.av2 = GlobalValues.av2;
            YandexGame.SaveProgress();
            UpdateSelectorTexts();
        }
    }
}

public void BuyAv3()
{
    if (!YandexGame.savesData.av3)
    {
        if (GlobalValues.money >= 350)
        {
            buyaudio.Play();
            GlobalValues.money -= 350;
            GlobalValues.skinid = 3;
            YandexGame.savesData._money = GlobalValues.money;
            YandexGame.savesData._avatarid = GlobalValues.skinid;
            moneyTitle.text = "Монет: " + GlobalValues.money;
            avatarimg.sprite = sprites[2];
            GlobalValues.av3 = true;
            YandexGame.savesData.av3 = GlobalValues.av3;
            YandexGame.SaveProgress();
            UpdateSelectorTexts();
        }
    }
}

public void BuyAv4()
{
    if (!YandexGame.savesData.av4)
    {
        if (GlobalValues.money >= 600)
        {
            buyaudio.Play();
            GlobalValues.money -= 600;
            GlobalValues.skinid = 4;
            YandexGame.savesData._money = GlobalValues.money;
            YandexGame.savesData._avatarid = GlobalValues.skinid;
            moneyTitle.text = "Монет: " + GlobalValues.money;
            avatarimg.sprite = sprites[3];
            GlobalValues.av4 = true;
            YandexGame.savesData.av4 = GlobalValues.av4;
            YandexGame.SaveProgress();
            UpdateSelectorTexts();
        }
    }
}
}