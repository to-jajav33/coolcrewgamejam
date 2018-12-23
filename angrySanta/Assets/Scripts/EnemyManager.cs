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
		TEST,
		TWO_HOUSES_W_GARAGE,
		TWO_DETACHED_HOUSES_NO_GARAGE,
		THREE_HOUSES_W_GARAGE,
		TWO_DETACHED_HOUSES_NO_GARAGE2,
		THREE_DETACHED_HOUSES_W_GARAGE2,
		FOUR_DETACHED_HOUSES_W_GARAGE2,
	}
	public AvailableEnemiesEnum ENEMY_TO_GENERATE = 0;
	public AvailableBuildings BUILDING_TO_GENERATE = 0;



	[SerializeField]
	public List<GameObject> listOfEnemies;
	[SerializeField]
	public List<GameObject> listOfBuildings;


	// Use this for initialization
	void Start () {
		int selectedEnemyInt = (int)ENEMY_TO_GENERATE;
		int selectedBuildingInt = (int)BUILDING_TO_GENERATE;

		if (((int)selectedEnemyInt > 0) && (selectedEnemyInt <= listOfEnemies.Count)) {
			// MINUS ON SINCE ENUM USES 0 AS NONE.
			Instantiate(listOfEnemies[selectedEnemyInt - 1], transform.position, Quaternion.identity);
		} else if ((selectedBuildingInt > 0) && (selectedBuildingInt <= listOfBuildings.Count)) {
			// MINUS ON SINCE ENUM USES 0 AS NONE.
			Instantiate(listOfBuildings[selectedBuildingInt - 1], transform.position, Quaternion.identity);
		}
	}

	void mySpawnEnemy () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
