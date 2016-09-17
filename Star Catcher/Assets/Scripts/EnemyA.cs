using UnityEngine;
using System.Collections;

public class EnemyA : MonoBehaviour {


	/*public Rigidbody rb;
	private float gravity = -1f;
	public float scuddle;

	IEnumerator Move () {
		rb.transform.Translate (scuddle * Time.deltaTime, gravity, 0);
		yield return null;
		StartCoroutine (Move ());
	}*/

	void Start () {
		StartCoroutine (Move (Vector3.left));
	}

	public float timeStep;



	IEnumerator Move(Vector3 dir)
	{

		float t = 0;
		//float duration = timeStep;


		GetComponent<Renderer>().material.color = Color.blue;
		while(t<timeStep)
		{
			transform.Translate(dir*Time.deltaTime);

			t += Time.deltaTime;
			yield return null;
		}

		t = 0;

		GetComponent<Renderer>().material.color = Color.red;

		yield return null;
		//yield return new WaitForSeconds (timeStep);

		Vector3 newDir = Quaternion.Euler(0,180,0) * dir;


		StartCoroutine(Move(newDir));
	}


}
