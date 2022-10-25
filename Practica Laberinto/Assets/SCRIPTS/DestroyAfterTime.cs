using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float timeToDestroy = 30;

    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}