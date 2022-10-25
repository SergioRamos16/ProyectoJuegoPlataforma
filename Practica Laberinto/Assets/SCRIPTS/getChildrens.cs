using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getChildrens : MonoBehaviour
{
    public MeshRenderer mesh;

    public MeshRenderer[] meshes;

    private void Start()
    {
        meshes = GetComponentsInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}