using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyBaseClass : MonoBehaviour {

	public GameObject PC;

	[Header("Enemy Navigation Attributes")]
	public Transform Target;
	public NavMeshAgent NVM_Agent;
	
	[Header("Enemy Movement Attributes")]
	public Rigidbody RB;
	public float MovementSpeed;
	public float  Health;

	[Header("UI Elements")]
	public GameObject Main_UI;
	public Image HealthBar;

	public void CalculateDamage(float DamageTaken)
	{
		StopCoroutine(TurnOffHealthBar());
		HealthBar.enabled = true;
		Health -= DamageTaken;
		CheckDeath();
		UpdateHealthBar();
	}

	void CheckDeath()
	{
		if(Health <=0)
		{
			Destroy(gameObject);
		}
	}

	void UpdateHealthBar()
	{
		float newXSize = Health / 100;
		Vector2 newSize = new Vector2(newXSize, HealthBar.rectTransform.sizeDelta.y);
		HealthBar.rectTransform.sizeDelta = newSize;
		StartCoroutine(TurnOffHealthBar());
	}

	IEnumerator TurnOffHealthBar()
	{
		yield return new WaitForSeconds(0.5F);
		HealthBar.enabled = false;
	}

}
