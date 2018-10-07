using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnerScript : MonoBehaviour {

    public float timeToSpawn = 4;
    int spawnCount = 0;
    public GameObject enemyPref, waypointParent;
    public GameObject timeSpawnText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timeToSpawn <= 0) {
            StartCoroutine(SpawnEnemy(spawnCount + 1));
            timeToSpawn = 4;
        }

        timeToSpawn -= Time.deltaTime;
        timeSpawnText.GetComponent<Text>().text = Mathf.Round(timeToSpawn).ToString() + " before new wave!!!";

    }

    IEnumerator SpawnEnemy(int enemyCount) {

        spawnCount++;

        for (int i = 0; i < enemyCount; i++) {
            GameObject tmpEnemy = Instantiate(enemyPref);
            tmpEnemy.transform.SetParent(gameObject.transform, false);
            tmpEnemy.GetComponent<EnemyScript>().waypointsParent = waypointParent;
            yield return new WaitForSeconds(0.5f);

        }


    }
}
