using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour
{
	[SerializeField] Transform	Parent;
	[SerializeField] GameObject	ObstaclePrefab;
	[SerializeField] float		StartDelay = 2.0f;
	[SerializeField] float		Interval = 2.0f;
	Vector3 SpawnPos = new Vector3(25, 0, 0);

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("SpawnObstacle", StartDelay, Interval);
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	void	SpawnObstacle()
	{
		GameObject ObstacleInstance = Instantiate(ObstaclePrefab, SpawnPos, ObstaclePrefab.transform.rotation);
		ObstacleInstance.transform.parent = Parent;
	}
}
