// External release version 2.0.0

using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Custom character controller, to be used by attaching the component to an object
/// and writing scripts attached to the same object that recieve the "SuperUpdate" message
/// </summary>
public class NewSuperCharacterController : MonoBehaviour {
	
	public float deltaTime;
	public Vector3 up;

	public float radius;


	private void Update() {
		deltaTime = Time.deltaTime;
		up = transform.up;
		gameObject.SendMessage("SuperUpdate", SendMessageOptions.DontRequireReceiver);
	}

	private void FixedUpdate() {

	}

	public bool IsGrounded (bool bl, float fl) {
		return Physics.Raycast(transform.position, Vector3.down, 0.1f);
	}
}
