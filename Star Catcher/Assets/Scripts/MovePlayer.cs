using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public Rigidbody rb;
	private float moveSpeed = 8;
	private float jumpSpeed = 3;
	private float jumpLimit = 4;
	public bool isGrounded = true;


	void Start () {
		isGrounded = true;
		jumpLimit = 4;
		rb = GetComponent<Rigidbody>();
	}

	void Jump(){
		rb.AddForce (0, 100 * jumpSpeed * jumpLimit--, 0);
		Debug.Log ("Jump" + jumpLimit);
	}

	void Move () {
		rb.transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed, 0, 0);
	}

	void OnTriggerEnter (){
		jumpLimit = 2;
		isGrounded = true;
		moveSpeed = 8;
	}

	void OnTriggerExit() {
		isGrounded = false;
		moveSpeed = 4;
	}

	void Update () {
		Move ();
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump();
		}
	}
}
