using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	[Header("Shooting Variables")]
	[SerializeField] private float Range;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton(0))
		{
			Fire();
		}
	
	}

	void Fire()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F,0.5F,0));
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, Range))
		{
			hit.collider.gameObject.SendMessage("Hit", SendMessageOptions.DontRequireReceiver);
		}
	}
}
