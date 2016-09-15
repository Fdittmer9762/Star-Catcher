using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	private Rigidbody rb;
	public float moveSpeed;
	private float jumpSpeed = 3;
	private float jumpLimit;
	public bool isGrounded = true;


	void Start () {
		isGrounded = true;
		jumpLimit = 4;
		rb = GetComponent<Rigidbody>();
		StartCoroutine (Move ());
		StartCoroutine (Jump ());
	}

	IEnumerator Jump(){
		if(Input.GetKeyDown(KeyCode.Space)){
			//rb.transform.Translate (0, 25 * jumpSpeed * jumpLimit--* Time.deltaTime, 0);
			rb.AddForce (0, 100 * jumpSpeed * jumpLimit--, 0);
			Debug.Log ("Jump" + jumpLimit);
		}
		yield return null;
		StartCoroutine (Jump ());
	}

	IEnumerator Move () {
		rb.transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed, 0, 0);
		yield return null;
		StartCoroutine (Move ());
	}

	IEnumerator Slide() {
		yield return null;
	}

	void OnTriggerEnter (){
		jumpLimit = 2;
		isGrounded = true;
		//moveSpeed = 8; //not needed without limiter
	}

	void OnTriggerExit() {
		isGrounded = false;
		//moveSpeed = 4; //removed limit on lateral movement while airborne, removed issues with module setup
	}

	void OnDisable (){
		//set gamestate to gameover
		Debug.Log("Dead!");
		GameStates.currentGameState = GameStates.gameState.GameOver;
	}


}
