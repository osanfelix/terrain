using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour: MonoBehaviour
{
	Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision collision){
		Debug.Log("He chocado con " + collision.gameObject.name);
	}

	private void OnCollisionExit(Collision collision){
		Debug.Log("Dejo de tocar a " + collision.gameObject.name);
	}

	private void OnCollisionStay(Collision collision){
		// la esfera rodará hacia el eje 'z' global
		rb.AddTorque(Vector3.right * 100 * Time.deltaTime);
	}
}
