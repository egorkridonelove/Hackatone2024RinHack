using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using YG;

public class UID_Child : MonoBehaviour
{
    public Text uiText;
    public int stringLength = 36;
    private string generatedString;

    private void Start()
    {
        generatedString = GenerateRandomString(stringLength);
        uiText.text = generatedString;
        GlobalValues.uid = generatedString;
        YandexGame.savesData._uid = GlobalValues.uid;
        YandexGame.SaveProgress();
    }

    private string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+[]{}|;:,.<>?";
        char[] stringChars = new char[length];
        System.Random random = new System.Random();

        for (int i = 0; i < length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(stringChars);
    }

    [DllImport("__Internal")]
    private static extern void CopyToClipboard(IntPtr textPtr, int textLength);

    public void CopyToClipboard()
    {
        byte[] stringBytes = System.Text.Encoding.UTF8.GetBytes(generatedString);
        int textLength = stringBytes.Length;

        IntPtr textPtr = Marshal.AllocHGlobal(textLength);
        Marshal.Copy(stringBytes, 0, textPtr, textLength);

        CopyToClipboard(textPtr, textLength);

        Marshal.FreeHGlobal(textPtr);

        GlobalValues.isauth = true;
        YandexGame.savesData._authorized = GlobalValues.isauth;
        YandexGame.SaveProgress();
    }
}