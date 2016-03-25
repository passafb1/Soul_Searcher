using UnityEngine;
using System.Collections;

public class MiniGameManager : MonoBehaviour {

	public int minigameNumber = 0;
	[SerializeField]  public static bool isPickedUp = false;
	public  bool isWin = false;
	public GameObject background1;

	 
	// Use this for initialization
	void Start () {
		background1.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

		switch (minigameNumber) {

		case 0: 
			if (isPickedUp == true) {
				background1.SetActive(true);
				if (isWin == false) {
					// Enter Game Play
					Debug.Log("PLAYING THE MINI GAME HERE");
					
					if (Input.anyKeyDown) { //Enter Win Condition
						isWin = true;
						background1.SetActive (false);
						Debug.Log("I WON THE MINI GAME");
						isPickedUp = false;
						minigameNumber += 1;



					} 
				} else {
					isPickedUp = false;
				}

			}else{

			}
			break;
		
		case 1:
			
			Debug.Log("I AM IN SECOND CASE");
			if (isPickedUp == true) {
				Debug.Log("I AM IN SECOND MINI GAME");
				background1.SetActive(true);
				if (isWin == false) {
					// Enter Game Play
					Debug.Log("PLAYING THE MINI GAME HERE");

					if (Input.anyKeyDown) { //Enter Win Condition
						isWin = true;
						background1.SetActive (false);
						Debug.Log("I WON THE MINI GAME");
						isPickedUp = false;
						minigameNumber += 1;



					} 
				} else {
					isPickedUp = false;
				}

			}else{

			}

			break;

		case 2:
			if (isPickedUp == true) {
				background1.SetActive(true);
				if (isWin == false) {
					// Enter Game Play
					Debug.Log("PLAYING THE MINI GAME HERE");

					if (Input.anyKeyDown) { //Enter Win Condition
						isWin = true;
						background1.SetActive (false);
						Debug.Log("I WON THE MINI GAME");
						isPickedUp = false;
						minigameNumber += 1;



					} 
				} else {
					isPickedUp = false;
				}

			}else{

			}
			break;

		case 3:
			isPickedUp = false;

			break;
		case 4:
			isPickedUp = false;

			break;

		case 5:
			isPickedUp = false;

			break;

		case 6:
			isPickedUp = false;

			break;

		case 7:
			isPickedUp = false;

			break;

		case 8:
			isPickedUp = false;

			break;

		case 9:
			isPickedUp = false;

			break;

		case 10:
			isPickedUp = false;

			break;

		case 11:
			isPickedUp = false;

			break;
		
		default:
			isPickedUp = false;

			break;

		
		}
	
	}
}
