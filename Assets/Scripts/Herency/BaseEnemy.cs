using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BaseEnemy : MonoBehaviour
{
	//public string name;
	public float damage;
	public PostProcessVolume damageVol;
	public ChromaticAberration _chromaticAberration;
	
	void Start()
	{
		damageVol.profile.TryGetSettings(out _chromaticAberration);
	}
	
}
