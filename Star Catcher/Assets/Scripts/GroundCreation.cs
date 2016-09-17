using UnityEngine;
using System.Collections;

public class GroundCreation : MonoBehaviour {

	int countdown;
	int rndNumber;
	bool gap;
	public float delay = 2f;

	public Transform groundSpawn;

	public GameObject ground1;
	public GameObject ground2;
	public GameObject slopeUp;
	public GameObject slopeDown;
	public GameObject groundEnd;
	public GameObject groundStart;

	void Start(){
		//float camSpeed = CameraMover.camSpeed.x;
		//delay = 100 / camSpeed;
		StartCoroutine (Spawner ());
	}

	IEnumerator Spawner (){
		rndNumber = Random.Range (0, 4);//set rndNumber to random number
		yield return new WaitForSeconds (delay);
		Ground ();
	}

	IEnumerator Gap (){
		Instantiate(groundEnd, groundSpawn.position, Quaternion.identity);
		while(countdown > 0){
			countdown--;
			yield return new WaitForSeconds (delay);
		}
		Instantiate(groundStart, groundSpawn.position, Quaternion.identity);//spawn Ground start
		StartCoroutine (Spawner ());
	}

	void Ground(){
		switch (rndNumber) {
		case 1:
			Instantiate(ground1, groundSpawn.position, Quaternion.identity);
			StartCoroutine (Spawner ());
			break;
		case 2:
			Instantiate(ground2, groundSpawn.position, Quaternion.identity);
			StartCoroutine (Spawner ());
			break;
		case 3:
			transform.Translate (transform.up);
			Debug.Log (transform.position + "up");
			Instantiate(slopeUp, groundSpawn.position, Quaternion.identity);
			StartCoroutine (Spawner ());
			break;
		case 4:
			transform.Translate (0,-1,0);
			Debug.Log (transform.position + "down");
			Instantiate(slopeDown, groundSpawn.position, Quaternion.identity);
			StartCoroutine (Spawner ());
			break;
		case 0:
			countdown = Random.Range (4, 8);//set countdown to random number
			StartCoroutine (Gap());
			break;
		}
	}

}
