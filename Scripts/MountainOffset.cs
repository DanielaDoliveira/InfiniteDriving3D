﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainOffset : MonoBehaviour
{
    private Material mountainMaterial;
    float scrollSpeed = 0.02f;
      Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        mountainMaterial = GetComponent<Material>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
