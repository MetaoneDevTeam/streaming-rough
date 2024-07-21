using System;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        Debug.Log("TEST");
    }

    private void OnTriggerEnter(Collider other)
    {
        _meshRenderer.material.color = Color.red;
    }

    private void OnTriggerExit(Collider other)
    {
        _meshRenderer.material.color = Color.gray;
    }
}
