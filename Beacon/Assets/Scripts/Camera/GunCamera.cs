using UnityEngine;
using System.Collections;

public class GunCamera : MonoBehaviour {

	[SerializeField] private Transform TargetCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = TargetCamera.position;
		transform.rotation = TargetCamera.rotation;
	
	}
}
