using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameControllerScript : MonoBehaviour {

	// Use this for initialization	
	public int cellCount;

    public List<GameObject> wayPoints = new List<GameObject>();

    int[] pathId = {
        9,30,51, 52,53,54,75,96,117,138,159,180,201,200,
    };

    List<CellScript> AllCells = new List<CellScript>();

	public Transform cellGroup;

    //Prefabs
	public GameObject cellPref;
    public GameObject waypointPref;

	void Start () {
		CreateCells();
        CreatePath();

    }

	void CreatePath() {
        for (int i = 0; i < pathId.Length; i++) {
            AllCells[pathId[i] - 1].SetState(1);
        }
	}

	void CreateCells() {
		for(int i = 0; i < cellCount; i++) {
			GameObject tmpCell = Instantiate(cellPref);
			tmpCell.transform.SetParent(cellGroup, false);
			tmpCell.GetComponent<CellScript>().id = i + 1;
			tmpCell.GetComponent<CellScript>().SetState(0);
            AllCells.Add(tmpCell.GetComponent<CellScript>());
		}
	}
	
	// Update is called once per frame
}
