using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
	[SerializeField] GameObject	ObstaclePrefab;
	Vector3 SpawnPos = new Vector3(25, 0, 0);

	// Start is called before the first frame update
	void Start()
	{
		Instantiate(ObstaclePrefab, SpawnPos, ObstaclePrefab.transform.rotation);
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
