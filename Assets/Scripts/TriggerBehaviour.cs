 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour {

	private void OnTriggerEnter(Collider other){
		// Se ejecuta al acceder a la zona
	}

	private void OnTriggerExit(Collider other){
		// Se ejecuta al salir de la zona
	}

	private void OnTriggerStay(Collider other)	{
		// Se ejecuta frame a frame
		// mientras está en la zona
	}
}
