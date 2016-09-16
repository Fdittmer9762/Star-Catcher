using UnityEngine;
using System.Collections;

public class StarCreator : MonoBehaviour {

	public GameObject starPrefab;
	public Transform starspawn;
	public Vector3 spawnPos;
	public float showerDelay, delayMin, delayMax, posRange;

	IEnumerator StarShower(){
		showerDelay = Random.Range(delayMin,delayMax);
		spawnPos.x = Random.Range (-1 * posRange, posRange);
		Instantiate(starPrefab, spawnPos, Quaternion.identity);
		Debug.Log (spawnPos);
		yield return new WaitForSeconds (showerDelay);
		StartCoroutine (StarShower ());
	}

	/*IEnumerator MoveShower() {
		spawnPos += CameraMover.camSpeed * Time.deltaTime;
		yield return null;
		StartCoroutine (MoveShower ());
	}*/

	void Start () {
		//spawnPos = starspawn;
		StartCoroutine (StarShower ());
		//StartCoroutine (MoveShower ());
	}
}
