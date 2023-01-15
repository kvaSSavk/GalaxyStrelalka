using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundHelper : MonoBehaviour
{
    public Renderer beckGroundRenderer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (beckGroundRenderer != null) {
            beckGroundRenderer.material.mainTextureOffset = new Vector2(0f, 0.1f * Time.time);
        }
    }
}
