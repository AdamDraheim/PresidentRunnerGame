using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {
    //variables
    float timeSinceLastFrame; //the time since the last frame passed

	// Use this for initialization
	void Start() {
        timeSinceLastFrame = 0;
	}
	
	// Update is called on Click
	void Update() {
        if (timeSinceLastFrame >= 5)
        {
            SceneManager.LoadScene("MainMenu");
        }
        timeSinceLastFrame += Time.deltaTime;
	}
}
