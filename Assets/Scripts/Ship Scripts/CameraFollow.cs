using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject target;   // Nave
	public GameObject cameraPosition;

	public float smoothFactor = 1f;

	// Update is called once per frame
	void Update () {
		transform.LookAt(target.transform);
		transform.position = Vector3.Lerp(transform.position, cameraPosition.transform.position, Time.deltaTime * smoothFactor);
	}
}
