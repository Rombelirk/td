using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellScript : MonoBehaviour {
	public int id, state;
	public Color normCol, pathCol;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void SetState(int i) {
		state = i;

		if(i == 0) {
			GetComponent<Image>().color = normCol;

		}
		if (i == 1) {
			GetComponent<Image>().color = pathCol;
		}
	}
}
