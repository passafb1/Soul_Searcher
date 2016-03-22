using UnityEngine;
using System.Collections;

public class MiniGameManager : MonoBehaviour {

	public int minigameNumber = 0;
	[SerializeField]  public static bool isPickedUp = false;
	public  bool isWin = false;
	public GameObject background1;
	public GameObject test;
	 
	// Use this for initialization
	void Start () {
		background1.SetActive(false);
		test.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

		switch (minigameNumber) {

		case 0: 
			if (isPickedUp == true) {
				background1.SetActive(true);
				test.SetActive(true);
				if (isWin == false) {
					
					if (Input.anyKeyDown) {
						isWin = true;
					} 
				} else {
					isPickedUp = false;
				}

			}else{
			background1.SetActive (false);
			test.SetActive (false);
//			minigameNumber++;
			}
			break;
		
		case 1:
			isPickedUp = false;

			break;

		case 2:
			isPickedUp = false;

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
