using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

	}
	
	// Update is called once per frame
	void Update () {


        transform.position = (player.transform.position - new Vector3(-5, player.transform.position.y, 10));

	}
}
