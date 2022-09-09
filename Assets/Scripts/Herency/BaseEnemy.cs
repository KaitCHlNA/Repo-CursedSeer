using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BaseEnemy : MonoBehaviour
{
	public float damage;
	public PostProcessVolume damageVolume;
	public ChromaticAberration _chromaticAberration;

	public void GetCompSettings()
	{
		damageVolume.profile.TryGetSettings(out _chromaticAberration);
	}
}
