using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesesRojos : MonoBehaviour
{
    private MeshRenderer[] meshes;

    private void Start()
    {
        meshes = GetComponentsInChildren<MeshRenderer>();
        for (int i = 0; i < meshes.Length; i++)
        {
            meshes[i].material.color = Color.red;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}