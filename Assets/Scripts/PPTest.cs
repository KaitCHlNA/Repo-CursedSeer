using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PPTest : MonoBehaviour
{
    public PostProcessVolume damageVol;
    private Grain _grain;
    private ChromaticAberration _chromaticAberration;
    
    void Start()
    {
        damageVol.profile.TryGetSettings(out _grain);
        damageVol.profile.TryGetSettings(out _chromaticAberration);
    }

    
    void Update()
    {
        
    }
}
