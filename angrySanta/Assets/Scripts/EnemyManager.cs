using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
	[System.Serializable]
	public enum AvailableEnemiesEnum {
		NONE,
		TEST
	}
	public enum AvailableBuildings {
		NONE,
		TEST
	}
	public AvailableEnemiesEnum ENEMY_TO_GENERATE = 0;
	public AvailableBuildings BUILDING_TO_GENERATE = 0;

	public GameObject PREFAB_ENEMY_TEST;
	public GameObject PREFAB_BUILDING_TEST;


	// Use this for initialization
	void Start () {
		float x = 0f;
		float y = 0f;

		if (ENEMY_TO_GENERATE > 0) {
			switch (ENEMY_TO_GENERATE) {
			case AvailableEnemiesEnum.TEST:
				Instantiate(PREFAB_ENEMY_TEST, new Vector3(x, y, 0), Quaternion.identity);
				break;
			case AvailableEnemiesEnum.NONE:
			default:
				break;
			}
		} else if (BUILDING_TO_GENERATE > 0) {
			switch (BUILDING_TO_GENERATE) {
			case AvailableBuildings.TEST:
				break;
			case AvailableBuildings.NONE:
			default:
				break;
			}
		}
	}

	void mySpawnEnemy () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
