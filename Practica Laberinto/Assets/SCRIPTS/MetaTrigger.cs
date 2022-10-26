using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaTrigger : playertrigger
{
    public override void OnPlayerEnter(GameObject playerobjet)
    {
        LevelManager levelManager = GetComponent<LevelManager>();
        levelManager.NextLevel();
    }
}