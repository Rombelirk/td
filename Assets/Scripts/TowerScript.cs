using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour {

    float range = 2;
    public GameObject projectile;
    public float currCooldown, cooldown;

    void Update()
    {
        if (CanShoot())
        {
            SearchTarget();
        }

        if (currCooldown > 0)
        {
            currCooldown -= Time.deltaTime;

        }


    }

    bool CanShoot() {
        return currCooldown <= 0;
    }

    void SearchTarget() {
        Transform nearestEnemy = null;
        float nearestEnemyDistance = Mathf.Infinity;

        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy")) {
            float currDistance = Vector2.Distance(transform.position, enemy.transform.position);

            if (currDistance < nearestEnemyDistance && currDistance <= range) {
                nearestEnemy = enemy.transform;
                nearestEnemyDistance = currDistance;
            }
        }

        if (nearestEnemy != null) {
            Shoot(nearestEnemy);
        }

    }

    void Shoot(Transform enemy) {

        currCooldown = cooldown;

        GameObject proj = Instantiate(projectile);
        projectile.transform.position = transform.position;
        projectile.GetComponent<TowerProjectileScript>().target = enemy;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

}
