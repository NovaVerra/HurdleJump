using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
	[SerializeField] Vector3	StartingPos = new Vector3(47.0f, 9.5f, 4.0f);
	float	MidwayPoint;
	// Start is called before the first frame update
	void Start()
	{
		MidwayPoint = GetComponent<BoxCollider>().size.x / 2;
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.x < StartingPos.x - MidwayPoint)
		{
			transform.position = StartingPos;
		}
	}
}
