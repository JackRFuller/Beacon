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
	public Renderer Gun;
	public Animator GunAnimations;
	public Material Gun_TubeGlass;
	public Color GunColor;
	public float Emission = 0.1F;

	[Header("Particle System")]
	public ParticleSystem PS_Gun;

	[Header("Cameras")]
	public Camera SecondaryCamera;

	// Use this for initialization
	void Start () {


	
	}




	public void UpdateTubeGlass()
	{

		float intensity = 5.0f;
		Gun_TubeGlass.EnableKeyword ("_EMISSION");
		Gun_TubeGlass.SetColor("_EmissionColor", new Color(0.0f,0.7f,1.0f,1.0f) * intensity);


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
