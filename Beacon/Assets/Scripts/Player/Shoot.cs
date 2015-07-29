using UnityEngine;
using System.Collections;

public class Shoot : GunClass {

	#region Enums

	public enum GunMode
	{
		Standard,
		Forcefield,
		SlowZone,
		LaunchPad
	}

	public GunMode CurrentGunMode;

	public enum GunType
	{
		SingleShot,
		Automatic
	}
	public GunType CurrentGunType;

	#endregion

	private float CooldownTime;

	// Use this for initialization
	void Start () {

		InitiliseAmmo();

		CurrentGunMode = GunMode.Standard;	
		CurrentGunType = GunType.SingleShot;

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton(0))
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;

			if(CurrentGunMode == GunMode.Standard)
			{
				CalculateAccuracy();
			}
		}

		if(Input.GetMouseButtonUp(0))
		{
			CanShoot = true;
		}
	
	}

	void CalculateAccuracy()
	{

		float Accuracy = 0;

		//Accuracy Calculations
		if(Input.GetMouseButton(1))
		{
			Accuracy = Random.Range(Zoomed_In_Weapon_Accuracy[0],Zoomed_In_Weapon_Accuracy[1]);
			Debug.Log("Hit");
		}
		else
		{
			Accuracy = Random.Range(Weapon_Accuracy[0],Weapon_Accuracy[1]);
		}

		FireStandardWeapon(Accuracy);

	}

	void FireStandardWeapon(float Accuracy)
	{
		if(CooldownTime < Time.realtimeSinceStartup && CanShoot)
		{
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(Accuracy,Accuracy,0));
			Debug.DrawRay(ray.origin,ray.direction * Weapon_Range, Color.red,0.1F);
			RaycastHit hit;

			CurrentClipSize--;
			UpdateTubeGlass();
			AmmoUIUpdate();
			if(CurrentClipSize == 0)
			{
				Reload();
			}
			
			if(Physics.Raycast(ray, out hit, Weapon_Range))
			{
				float SentWeaponDamage = Weapon_Damage;
				
				if(hit.collider.tag == "Head")
				{
					SentWeaponDamage *= HeadshotMultiplier;
					hit.collider.gameObject.transform.parent.root.SendMessage("CalculateDamage",SentWeaponDamage, SendMessageOptions.DontRequireReceiver);
				}
				else
				{
					hit.collider.gameObject.SendMessage("CalculateDamage",SentWeaponDamage, SendMessageOptions.DontRequireReceiver);
				}
			}

			CooldownTime = Time.realtimeSinceStartup + Weapon_Cooldown;

			GunModifiers();

		}
	}

	void Reload()
	{
		if(CurrentAmmo > 1)
		{
			for(int i = 0; i < MaxClipSize; i++)
			{
				CurrentClipSize++;
				CurrentAmmo--;
				if(CurrentAmmo == 0)
				{
					break;
				}
			}

			AmmoUIUpdate();
		}
	}

	void GunModifiers()
	{
		if(CurrentGunType == GunType.SingleShot)
		{
			CanShoot = false;
		}
	}
}
