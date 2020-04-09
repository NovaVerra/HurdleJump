using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Config */
	Rigidbody	RB_Player;
	bool		b_TouchedFloor = true;
	[SerializeField] float	JumpForce = 750.0f;
	[SerializeField] float	GravityModifier = 1.0f;

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
		if (Input.GetKeyDown(KeyCode.Space) && b_TouchedFloor)
		{
			float	JumpForceThisFrame = JumpForce * Time.deltaTime;
			RB_Player.AddForce(Vector3.up * JumpForceThisFrame, ForceMode.Impulse);
		}
	}
}
