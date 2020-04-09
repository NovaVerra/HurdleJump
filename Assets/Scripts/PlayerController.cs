using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Config */
	Rigidbody	Player;
	[SerializeField] float	JumpForce = 500.0f;

	// Start is called before the first frame update
	void Start()
	{
		Player = GetComponent<Rigidbody>();
		float	JumpForceThisFrame = JumpForce * Time.deltaTime;
		Player.AddRelativeForce(Vector3.up * JumpForceThisFrame);
	}

	// Update is called once per frame
	void Update()
	{
	}
}
