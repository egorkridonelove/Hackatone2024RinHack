using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Text starsText;
    [SerializeField] LeaderboardYG lbyg;
    [SerializeField] private Text moneyText;
    [SerializeField] private Text xpText;



    private void OnEnable()
    {
        YandexGame.LoadProgress();
        GlobalValues.stars = YandexGame.savesData._stars;
        GlobalValues.money = YandexGame.savesData._money;
        GlobalValues.xp = YandexGame.savesData._xp;
        lbyg.NewScore(GlobalValues.xp);
        starsText.text = "Звёзд: " + GlobalValues.stars.ToString();
        moneyText.text = "Монет: " + GlobalValues.money.ToString();
        xpText.text = "Опыт: " + GlobalValues.xp.ToString();
    }

}
