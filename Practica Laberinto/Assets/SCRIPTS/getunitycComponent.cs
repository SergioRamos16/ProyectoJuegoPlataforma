using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getunitycComponent : MonoBehaviour
{
    public MeshRenderer mesh;
    public Collider[] colliders;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        colliders = GetComponents<Collider>();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}