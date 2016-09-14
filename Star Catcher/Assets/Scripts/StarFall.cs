﻿using UnityEngine;
using System.Collections;

public class StarFall : MonoBehaviour {

	public Vector3 starTraject;
	public Rigidbody star;

	void Start () {
		star.useGravity = false;
		starTraject.x = Random.Range(-10f,0f);
	}

	void OnTriggerEnter () {
		star.velocity = starTraject;
		star.useGravity = true;
	}

}