using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour
{
	protected AudioSource source;

	// Asignar mediante el inspector
	public AudioClip clip;

	void Start ()
	{
		source = GetComponent<AudioSource>();
		source.volume = 0f;
		source.loop = true;
		source.clip = clip;
		source.Play();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (source.isPlaying && source.volume < 1f)
			source.volume += 0.1f * Time.deltaTime;
	}
}
