﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerProjectileScript : MonoBehaviour {

    public Transform target;
    float speed = 7;



	
	// Update is called once per frame
	void Update () {
       Move();
    }

   

    private void Move() {

       
        if (target != null) {
         
            if (Vector2.Distance(transform.position, target.position) < .1f) {
                Destroy(gameObject);
            } else {
               
                Vector2 dir = target.position - transform.position;
                transform.Translate(dir.normalized * Time.deltaTime * speed);
            }


        } else {
            Destroy(gameObject);
        }
     
    }
}
