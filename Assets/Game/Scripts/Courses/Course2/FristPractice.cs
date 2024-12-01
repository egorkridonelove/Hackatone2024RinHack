using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FristPractice : MonoBehaviour
{
    public Text p1;
    public Text p2;

    public GameObject next;

    private int ready = 0;

    public void Pract1Check()
    {
        if (p1.text == "name = input(\"Введите ваше имя: \")")
        {
            ready += 1;
        }
    }

    public void Pract2Check()
    {
        if (p2.text == "print(\"Привет,\", name, \"!\")")
        {
            ready += 1;
        }
    }

    public void Go()
    {
        if (ready == 2)
        {
            next.SetActive(true);
        }
    }
}
