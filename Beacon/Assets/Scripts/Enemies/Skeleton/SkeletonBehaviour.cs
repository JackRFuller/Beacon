using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkeletonBehaviour : EnemyBaseClass {

	[Header("Launching Attributes")]
	[SerializeField] private bool Launched;
	[SerializeField] private float UpEnergy;
	[SerializeField] private Vector3 RotationalEnergy;

	[Header("Deformation Attributes")]
	[SerializeField] private GameObject[] Limbs;

	// Use this for initialization
	void Start () {

		NVM_Agent = GetComponent<NavMeshAgent>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if(!Launched)
		{
			NVM_Agent.SetDestination(Target.position);
		}

		Main_UI.transform.LookAt(PC.transform.position);


	
	}

	void Hit()
	{
		Debug.Log("Success");
		Launched = true;
		NVM_Agent.enabled = false;
		RB.AddForce(Vector3.up * UpEnergy);
		RB.AddTorque(RotationalEnergy);

	}

	void BodySmash()
	{
		Destroy(gameObject);
	}

	void OnCollisionEnter(Collision Col)
	{
		if(Launched)
		{
			if(Col.collider.tag == "Floor")
			{			
				BodySmash();
			}
		}


	}
}
