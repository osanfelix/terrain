using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {

	public GameObject target;
	public GameObject cameraPosition;

	// Update is called once per frame
	void Update () {
		//transform.LookAt(target.transform);
		transform.position = Vector3.Lerp(transform.position, cameraPosition.transform.position, Time.deltaTime * 5f);
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position), Time.deltaTime * 5f);
	}
}