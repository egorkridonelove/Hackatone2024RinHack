using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundGenerator : MonoBehaviour
{
    public Text uiText;
    public float delayBetweenCharacters = 0.05f;
    public float delayBetweenBytes = 1f;
    private int columnCount = 0;

    private void Start()
    {
        StartCoroutine(GenerateBytes());
    }

    private IEnumerator GenerateBytes()
    {
        while (true)
        {
            byte randomByte = (byte)Random.Range(0, 256);
            string byteString = $"> 0x{randomByte:X2}\n";

            foreach (char c in byteString)
            {
                uiText.text += c;
                yield return new WaitForSeconds(delayBetweenCharacters);
            }

            columnCount++;

            if (columnCount >= 34)
            {
                uiText.text = "";
                columnCount = 0;
            }

            yield return new WaitForSeconds(delayBetweenBytes);
        }
    }
}
