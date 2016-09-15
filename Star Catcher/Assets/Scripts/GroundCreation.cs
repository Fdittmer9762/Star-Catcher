using UnityEngine;
using System.Collections;

public class GroundCreation : MonoBehaviour {

	int countdown;
	int rndNumber;
	bool gap;
	public float delay = .195f;

	public Transform groundSpawn;

	public GameObject ground1;
	public GameObject ground2;
	public GameObject ground3;
	public GameObject ground4;
	public GameObject groundEnd;
	public GameObject groundStart;

	void Start(){
		StartCoroutine (Spawner ());
	}

	IEnumerator Spawner (){
		rndNumber = Random.Range (0, 4);//set rndNumber to random number
		yield return new WaitForSeconds (delay);
		Ground ();
		//StartCoroutine (Spawner ());
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
			Instantiate(ground1, groundSpawn.position, Quaternion.identity);//spawn ground 1
			StartCoroutine (Spawner ());
			break;
		case 2:
			Instantiate(ground2, groundSpawn.position, Quaternion.identity);//spawn ground 
			StartCoroutine (Spawner ());
			break;
		case 3:
			Instantiate(ground3, groundSpawn.position, Quaternion.identity);//spawn ground 1
			StartCoroutine (Spawner ());
			break;
		case 4:
			Instantiate(ground4, groundSpawn.position, Quaternion.identity);//spawn ground 1
			StartCoroutine (Spawner ());
			break;
		case 0:
			countdown = Random.Range (2, 4);//set countdown to random number
			StartCoroutine (Gap());
			break;
		}
	}

}
