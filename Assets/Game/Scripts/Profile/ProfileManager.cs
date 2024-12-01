using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ProfileManager : MonoBehaviour
{

    public Text uidtext;
    public Text moneytext;
    public Text starstext;
    public Text xptext;

    public void OnEnable()
    {
        uidtext.text = "UID: " + YandexGame.savesData._uid;
        xptext.text = "Опыт: " + YandexGame.savesData._xp;
        starstext.text = "Звёзды: " + YandexGame.savesData._stars;
        moneytext.text = "Монеты: " + YandexGame.savesData._money;
    }
}
