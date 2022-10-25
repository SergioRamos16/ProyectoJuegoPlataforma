using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaker : playertrigger
{
    public int damageAmount = 20000;

    public override void OnPlayerEnter(GameObject playerobjet)
    {
        PlayerHealth healt = playerobjet.GetComponent<PlayerHealth>();
        healt.TakeDamage(damageAmount);
    }
}