﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform entityToFollow;
	public float speed;

	private new Transform transform;
	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 pos = entityToFollow.position;
		pos.x = Mathf.Clamp (pos.x, 170f, 183.9f);
		pos.y = Mathf.Clamp (pos.y, 79.5f, 104.4f);
		pos.z = transform.position.z;
		transform.position = Vector3.Lerp (transform.position, pos, Time.deltaTime * speed);
	}
}
