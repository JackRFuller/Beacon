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

}
