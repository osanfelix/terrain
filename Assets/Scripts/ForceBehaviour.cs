using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceBehaviour: MonoBehaviour
{
	Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(Vector3.forward* 2, ForceMode.VelocityChange);
	}
	
	void FixedUpdate () {
		rb.AddForce(new Vector3(0, 0, -1) * 2, ForceMode.Force);
	}
}
