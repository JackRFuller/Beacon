using UnityEngine;
using System.Collections;

public class EnemyBaseClass : MonoBehaviour {

	[Header("Enemy Navigation Attributes")]
	public Transform Target;
	public NavMeshAgent NVM_Agent;
	
	[Header("Enemy Movement Attributes")]
	public Rigidbody RB;
	public float MovementSpeed;
	public float  Health;

}
