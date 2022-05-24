using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float _rotationSpeed =20;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.7f, 1.0f, 0.3f, 1.0f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime *_rotationSpeed, 1.0f*Time.deltaTime, 1.0f);
    }
}
