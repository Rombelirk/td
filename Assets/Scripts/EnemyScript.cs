﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public GameObject waypointsParent;
    public GameObject child;

    List<GameObject> wayPoints = new List<GameObject>();
    int wayIndex = 0;
    int speed = 1;

	// Use this for initialization
	void Start () {
        GetWaypoints();

    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    void GetWaypoints() {
        for (int i = 0; i < waypointsParent.transform.childCount; i++) {
            wayPoints.Add(waypointsParent.transform.GetChild(i).gameObject);
        }
    }

    void Move() {
      
        Vector3 dir = wayPoints[wayIndex].transform.position - transform.position;
        transform.Translate(dir.normalized * Time.deltaTime * speed);

        var direct = wayPoints[wayIndex].transform.position - child.transform.position;
        var angle = Mathf.Atan2(direct.y, direct.x) * Mathf.Rad2Deg + -90;
        child.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        if (Vector3.Distance(transform.position, wayPoints[wayIndex].transform.position) < 0.1f) {

         

            if (wayIndex < wayPoints.Count - 1) {
                wayIndex++;


            } else {
                Destroy(gameObject);
            }
   
        }
    }
}
