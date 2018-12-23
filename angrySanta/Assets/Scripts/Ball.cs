using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float maxDragDistance = 2f;
	public float waitReleasetime = 0.15f;
	public Rigidbody ball;
	public Rigidbody hook;
	private bool isPressed = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (isPressed) {
			Vector3 mouseToCamToBallPos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane - ball.position.z));
			mouseToCamToBallPos = new Vector3 (mouseToCamToBallPos.x, mouseToCamToBallPos.y, ball.position.z);

			if (Vector3.Distance (mouseToCamToBallPos, hook.position) > maxDragDistance) {
				ball.position = hook.position + (mouseToCamToBallPos - hook.position).normalized * maxDragDistance;
			} else {
				ball.position = mouseToCamToBallPos;
			}
		}
	}

	void OnMouseDown () {
		isPressed = true;
		ball.isKinematic = true;
	}

	void OnMouseUp () {
		isPressed = false;
		ball.isKinematic = false;
		StartCoroutine (Release ());
	}

	IEnumerator Release () {
		yield return new WaitForSeconds(waitReleasetime);

		// Debug.Log(GetComponent<SpringJoint>());

		Destroy(GetComponent<SpringJoint>().connectedBody);
		this.enabled = false;
	}
}
