using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

	//public float camDelay = .1f;
	public Rigidbody cam;
	public Vector3 camSpeed;
	//public Rigidbody player;

	/*IEnumerator PlayerFollow (){
		player = GetComponent <Rigidbody>; //tracks player
		float temp;
		temp = player.position.y;//move cam to player position
		temp = cam.position.y;
		yield return new WaitForSeconds (camDelay); // wait for some time
		StartCoroutine (PlayerFollow ()); //start again
	}*/

	void Start() {
		//StartCoroutine (PlayerFollow ());
		camSpeed.x = 25; //sets cam speed
		cam.velocity = camSpeed * Time.deltaTime;	//auto moves to the right
	}

}
