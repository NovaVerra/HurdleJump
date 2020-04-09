using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
	[SerializeField] float	Speed = 10.0f;
	PlayerController	PlayerControllerScript;
	// Start is called before the first frame update
	void Start()
	{
		PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
	}

	// Update is called once per frame
	void Update()
	{
		if (PlayerControllerScript.b_GameOver == false)
		{
			transform.Translate(Vector3.left * Speed * Time.deltaTime);
		}
	}
}
