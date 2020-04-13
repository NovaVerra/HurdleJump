using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game State */
	bool		b_IsOnGround = true;
	public bool	b_GameOver = false;

	/** Game Config */
	Rigidbody	RB_Player;
	Animator	AN_Player;
	AudioSource	S_Player;
	[SerializeField] ParticleSystem	PS_SmokeExplosion;
	[SerializeField] ParticleSystem	PS_DirtSplatter;
	[SerializeField] AudioClip		S_Jump;
	[SerializeField] AudioClip		S_Crash;
	[SerializeField] float	JumpForce = 30.0f;
	[SerializeField] float	GravityModifier = 10.0f;

	// Start is called before the first frame update
	void	Start()
	{
		RB_Player = GetComponent<Rigidbody>();
		AN_Player = GetComponent<Animator>();
		S_Player = GetComponent<AudioSource>();
		Physics.gravity *= GravityModifier;
	}

	// Update is called once per frame
	void	Update()
	{
		InputHandler();
		GameEndHandler();
	}

	void	InputHandler()
	{
		if (Input.GetKeyDown(KeyCode.Space) && b_IsOnGround && !b_GameOver)
		{
			RB_Player.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
			AN_Player.SetTrigger("Jump_trig");
			S_Player.PlayOneShot(S_Jump, 1.0f);
			PS_DirtSplatter.Stop();
			b_IsOnGround = false;
		}
	}

	void	GameEndHandler()
	{
		if (b_GameOver)
		{
			Debug.Log("Game Over!"); 
			AN_Player.SetBool("Death_b", true);
			AN_Player.SetInteger("DeathType_int", 1);
		}
	}

	void	OnCollisionEnter(Collision CollisionObject)
	{
		if (CollisionObject.gameObject.CompareTag("Ground"))
		{
			b_IsOnGround = true;
			PS_DirtSplatter.Play();
		}
		if (CollisionObject.gameObject.CompareTag("Obstacle"))
		{
			b_GameOver = true;
			PS_SmokeExplosion.Play();
			PS_DirtSplatter.Stop();
			S_Player.PlayOneShot(S_Crash, 1.0f);
		}
	}
}
