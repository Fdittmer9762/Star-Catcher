using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		other.gameObject.SetActive(false);
		Debug.Log (Time.time);
	}
}
