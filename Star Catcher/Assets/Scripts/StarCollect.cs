using UnityEngine;
using System.Collections;

public class StarCollect : MonoBehaviour {

	private GameObject star;

	void OnTriggerEnter (Collider other){
		Debug.Log ("Star Collected");
		other.gameObject.SetActive (false);
	}

}
