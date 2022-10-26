using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerParents : playertrigger
{
    public Transform platform;

    public void Update()
    {
        transform.position = platform.position;
    }

    public override void OnPlayerEnter(GameObject playerobjet)
    {
        playerobjet.transform.parent = transform;
    }

    public override void OnPlayerExit(GameObject playerObject)
    {
        playerObject.transform.parent = null;
    }
}