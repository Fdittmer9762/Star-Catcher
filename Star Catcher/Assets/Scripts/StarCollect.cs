using UnityEngine;
using System.Collections;

public class StarCollect : MonoBehaviour {

	public GameObject star;

	void OnTriggerEnter (){
		Debug.Log ("Star Collected");
		star.SetActive (false);
		//Add Star Points, may do in different script
	}

}
