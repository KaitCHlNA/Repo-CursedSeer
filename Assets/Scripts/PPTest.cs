using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PPTest : MonoBehaviour
{
    public PostProcessVolume inputAmbientOcl;
    private AmbientOcclusion _ambientOcclusion;

    void Start()
    {
        inputAmbientOcl.profile.TryGetSettings(out _ambientOcclusion);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _ambientOcclusion.intensity.value = 2.15f;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _ambientOcclusion.intensity.value = 0f;
        }
    }
}
