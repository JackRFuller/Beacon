using UnityEngine;
using System.Collections;

public class TestNavMesh : MonoBehaviour {

	public NavMeshAgent NVA;
	public Transform Target;

	// Use this for initialization
	void Start () {

		NVA = GetComponent<NavMeshAgent>();

	
	}
	
	// Update is called once per frame
	void Update () {

		NVA.SetDestination(Target.position);
	
	}
}
