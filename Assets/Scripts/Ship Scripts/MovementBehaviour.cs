using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour {

	public float speedFactor = 1f;
	public float rotateFactor = 1f;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * Time.deltaTime * speedFactor);
		}
		else if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(- Vector3.forward * Time.deltaTime * speedFactor);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up * Time.deltaTime * rotateFactor);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(- Vector3.up * Time.deltaTime * rotateFactor);
		}
	}
}
