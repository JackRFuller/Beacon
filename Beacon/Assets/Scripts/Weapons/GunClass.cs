using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GunClass : MonoBehaviour {

	[Header("Inidividual Weapon Variables")]
	public bool CanShoot;
	public float Weapon_Range;
	public float Weapon_Cooldown;
	public float Weapon_Damage;
	public float[] Weapon_Accuracy = new float[2];
	public float[] Zoomed_In_Weapon_Accuracy = new float[2];
	public float HeadshotMultiplier;

	[Header("Ammo Variables")]
	public int CurrentClipSize;
	public int MaxClipSize;
	public int MaxAmmoSize;
	public int CurrentAmmo;

	[Header("Ammo UI")]
	public Text CurrentClipText;
	public Text CurrentAmmoText;

	[Header("Gun Attributes")]
	public Animator GunAnimations;
	public Material Gun_TubeGlass;
	public float Emission = 0.1F;

	[Header("Particle System")]
	public ParticleSystem PS_Gun;

	// Use this for initialization
	void Start () {
	
	}



	public void UpdateTubeGlass()
	{

//		Color NewColor = Gun_TubeGlass.GetColor("_EmissionColor");
//		Rend.materials[3].EnableKeyword("_EMISSION");
//		Rend.materials[3].SetColor("_EmissionColor",NewColor * Emission);
//		DynamicGI.UpdateMaterials(Rend);
//		DynamicGI.UpdateEnvironment();

	}

	public void InitiliseAmmo()
	{
		CurrentClipSize = MaxClipSize;
		CurrentAmmo = MaxAmmoSize;

		CurrentClipText.text = CurrentClipSize.ToString();
		CurrentAmmoText.text = CurrentAmmo.ToString();
	}

	public void AmmoUIUpdate()
	{
		CurrentClipText.text = CurrentClipSize.ToString();
		CurrentAmmoText.text = CurrentAmmo.ToString();
	}

}
