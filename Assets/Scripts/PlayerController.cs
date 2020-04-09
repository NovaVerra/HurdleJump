using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Config */
	Rigidbody	RB_Player;
	bool		b_IsOnGround = true;
	[SerializeField] float	JumpForce = 30.0f;
	[SerializeField] float	GravityModifier = 10.0f;

	// Start is called before the first frame update
	void	Start()
	{
		RB_Player = GetComponent<Rigidbody>();
		Physics.gravity *= GravityModifier;
	}

	// Update is called once per frame
	void	Update()
	{
		InputHandler();
	}

	void	InputHandler()
	{
		if (Input.GetKeyDown(KeyCode.Space) && b_IsOnGround)
		{
			RB_Player.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
			b_IsOnGround = false;
		}
	}

	void	OnCollisionEnter(Collision CollisionObject)
	{
		b_IsOnGround = true;
	}
}
