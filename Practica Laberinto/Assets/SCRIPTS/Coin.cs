using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : playertrigger
{
    public int amountToGive = 1;

    public override void OnPlayerEnter(GameObject playerobjet)
    {
        CoinCounter counter = playerobjet.GetComponent<CoinCounter>();
        counter.GetCoins(amountToGive);
        gameObject.SetActive(false);
    }
}