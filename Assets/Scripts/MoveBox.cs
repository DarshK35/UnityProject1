using System;
using UnityEngine;

public class MoveBox : MonoBehaviour {
	[Header("Movement Variables")]
	public float vertInput;
	public float horInput;
	public float speed;
	private Vector3 moveSpeed;
	private Rigidbody rb;

	[Header("Camera Variables")]
	public Transform cameraPos;
	public Vector3 cameraOffset;
	public Quaternion cameraRot;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		cameraPos.position = transform.position + cameraOffset;
		cameraPos.rotation = cameraRot;

		vertInput = Input.GetAxis("Vertical");
		horInput = Input.GetAxis("Horizontal");

		moveSpeed = new Vector3(horInput, 0, vertInput) * speed;
		rb.velocity = moveSpeed;
	}
}
