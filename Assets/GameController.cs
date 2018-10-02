using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public void StartNewGame() {
        Debug.Log("ok");
        SceneManager.LoadScene("Scenes/Level1");
      
    }

    void Update() {
      
    }

  
}
