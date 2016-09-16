using UnityEngine;
using System.Collections;

public class StarFall : MonoBehaviour {

	public Vector3 starTraject;
	public Rigidbody star;
	//public Vector3 bounceForce;
	//public float gravity = -9.81f;

	void Start (){
		star.useGravity = true;
		starTraject.x = Random.Range (-5f, 10f);
		star.velocity= starTraject;
	}

	/*void Start () {
		starTraject.y = gravity;
		starTraject.x = Random.Range(-5f,10f);
		star.velocity = starTraject;
		bounceForce.y = 2* gravity;
	}

	void OnTriggerEnter () {
		star.AddForce (bounceForce);
		bounceForce /= 2;
		Debug.Log (bounceForce);
		//star.useGravity = true;
	}*/

}
