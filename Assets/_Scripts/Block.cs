using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    private GameObject player;
    private float difference = 7f;


    // Use this for initialization
    void Start () {
		
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");

        }


    }
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x - player.transform.position.x < -difference)
        {
            Vector3 position = new Vector3(transform.position.x + (1.6f * 15), transform.position.y, 0);

            transform.position = position;

        }

	}
}
