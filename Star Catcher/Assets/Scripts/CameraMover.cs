using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

	public Vector3 camSpeed;//x=3

	IEnumerator MoveCamera(){
		transform.Translate(camSpeed*Time.deltaTime);
		yield return null;
		StartCoroutine (MoveCamera ());
	}

	void Start() {
		StartCoroutine (MoveCamera());
	}

}
