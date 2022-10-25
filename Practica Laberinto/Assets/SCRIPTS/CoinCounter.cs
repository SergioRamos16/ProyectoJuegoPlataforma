using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentNumberOfCoins;
    public Text coinText;

    public void GetCoins(int cointAmount)
    {
        coinText.text = currentNumberOfCoins.ToString();
        currentNumberOfCoins += cointAmount;
        if (currentNumberOfCoins == 1)
        {
            Debug.Log("Has cogido una moneda, tienes " + currentNumberOfCoins + " moneda.");
            coinText.text = currentNumberOfCoins.ToString();
        }
        else
            Debug.Log("Has cogido una moneda, tienes " + currentNumberOfCoins + " monedas.");
        coinText.text = currentNumberOfCoins.ToString();
    }
}