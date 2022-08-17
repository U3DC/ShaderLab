using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterEffect : MonoBehaviour
{

    public Material gaosiMat;

    void OnRenderImage(RenderTexture srcTexture,RenderTexture desTexture)
    {
        Graphics.Blit(srcTexture, desTexture,gaosiMat);
    }
}
