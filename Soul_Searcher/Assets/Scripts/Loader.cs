using UnityEngine;
using System.Collections;

namespace Completed
{	
	public class Loader : MonoBehaviour 
	{
		public GameObject gameManager;			//GameManager prefab to instantiate.
		public GameObject soundManager;			//SoundManager prefab to instantiate.
		
		
		void Awake ()
		{

				//Instantiate gameManager prefab
				Instantiate(gameManager);

				//Instantiate SoundManager prefab
				Instantiate(soundManager);
		}
	}
}