using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    float parallax = 2f;
    void Update()
    {
        MeshRenderer myRenderer = GetComponent<MeshRenderer>();
        Material myMaterial = myRenderer.material;
        Vector2 offset = myMaterial.mainTextureOffset;
        offset.x += Time.deltaTime / 6 / parallax;
        myMaterial.mainTextureOffset = offset;
    }
}
