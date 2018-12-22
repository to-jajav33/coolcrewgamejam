using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiile : MonoBehaviour {
	public Rigidbody bulletPrefabs;
	public GameObject cursor;
	public LayerMask layer;


	private Camera cam;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void myLaunchProjectile () {
//		// get mouse position according to camera;
//		Ray camRay = cam.ScreenPointtoRay(Input.mousePosition);
//		RaycastHit hit;
//
//		if (Physics.Raycast(camRay, out hit, 100f, layer) {
//			cursor.SetActive(true);
//			cursor.transform.position = hit.point + Vector3.up * 0.1f;
//
//			Vector3 Vo = myCalculateVelocity(hit.point, transform.position, 1f);
//		}
	}

	Vector3 myCalculateVelocity (Vector3 target, Vector3 origin, float time) {
		// define the dist x and y first;
		Vector3 distanceY = target - origin;
		Vector3 distanceX = distanceY;

		// x travel will always have y as 0 since it is horizontal movement.
		distanceX.y = 0f;

		// create a float to hold magnitudes
		float height = distanceY.y;
		float deltaX = distanceX.magnitude;


		float vx = deltaX / time;
		float vy = height / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;

		Vector3 result = distanceX.normalized; // length of on.
		result *= vx;
		result.y = vy;

		return result;
 	}
}
