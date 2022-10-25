using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : playertrigger
{
    public Transform targetPosition;

    public override void OnPlayerEnter(GameObject playerobjet)
    {
        playerobjet.transform.position = targetPosition.position;
    }
}