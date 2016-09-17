using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

	public float force;

	void OnTriggerEnter (Collider other) {
		other.attachedRigidbody.AddForce (Vector3.up * force);
		Debug.Log ("Bounce!"+ force);
	}
}
