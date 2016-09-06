using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public Rigidbody rb;
	public float moveSpeed;
	public float jumpSpeed;
	private float jumpLimit = 2;
	public bool isGrounded = true;


	void Start () {
		isGrounded = true;
		jumpLimit = 2;
		rb = GetComponent<Rigidbody>();
	}

	void Jump(){
		rb.AddForce (0, 100 * jumpSpeed * jumpLimit--, 0);
	}

	void Move () {
		rb.transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed, 0, 0);
	}

	void OnTriggerEnter (){
		jumpLimit = 2;
		isGrounded = true;
	}

	void OnTriggerExit() {
		isGrounded = false;
	}

	void Update () {
		Move ();
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump();
		}
	}
}
