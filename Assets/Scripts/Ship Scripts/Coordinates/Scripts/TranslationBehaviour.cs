using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationBehaviour : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * Time.deltaTime * 10);
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(-Vector3.forward * Time.deltaTime * 10);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up * Time.deltaTime * 120);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(-Vector3.up * Time.deltaTime * 120);
		}
	}
}
