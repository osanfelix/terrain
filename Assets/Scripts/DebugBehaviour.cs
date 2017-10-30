using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugBehaviour : MonoBehaviour {

	int counter = 0;

	void Awake() {
		Debug.Log("Ejecutando Awake()");
	}

	void Start () {
		Debug.Log("Ejecutando Start()");
	}
	
	void Update () {
		if(counter < 3) {
			Debug.Log("Ejecutando Update()");
			counter++;
		}	
	}
}
