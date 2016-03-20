﻿using UnityEngine;
using System.Collections;

public class RatMove : MonoBehaviour {

	private CharacterController cont;
	public float speed=10f;
	private Vector3 oldPos;
	// Use this for initialization
	void Start () {
		oldPos = transform.position;
		InvokeRepeating ("CheckMove", 1f, 0.1f);
		cont = transform.parent.gameObject.GetComponent<CharacterController> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		cont.SimpleMove (Camera.main.transform.forward * speed);
	
	}

	void CheckMove()
	{
		Vector3 currentPos = transform.position;
		if (Vector3.Distance (currentPos, oldPos) < 0.1f) {
			Debug.Log ("nice");
			transform.eulerAngles = new Vector3 (0f, transform.eulerAngles.y+180f, 0f);
		} 
		oldPos = currentPos;
	}
}