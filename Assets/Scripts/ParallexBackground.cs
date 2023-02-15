using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallexBackground : MonoBehaviour
{
    public float animationSpeed = 0.5f;

    private MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();    
    }


    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
