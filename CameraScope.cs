using UnityEngine;

public class CameraScope : MonoBehaviour
{
    public RenderTexture renderTexture;
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, renderTexture);
        Graphics.Blit(src, dest);
    }
}
