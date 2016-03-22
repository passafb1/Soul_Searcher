using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Audio_hits : MonoBehaviour
{
	public AudioClip testSound;
	public AudioSource test;

	void Awake()
	{
		test = GetComponent<AudioSource> ();
	}
		
	void OnCollisionEnter2D(Collision2D collision)
	{
			test.PlayOneShot (testSound);
	}
}