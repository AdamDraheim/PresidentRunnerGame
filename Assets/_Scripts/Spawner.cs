using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject block;
    public GameObject token;
    // Use this for initialization


	void Start () {

        for(int i = 0; i < 15; i++)
        {
            Vector3 position = new Vector3(-10 + (1.6f * i), -4.5f, 0);

            Instantiate(block, position, new Quaternion(0, 0, 0, 0));

            position = new Vector3(-10 + (1.6f * i), 6f, 0);

            Instantiate(block, position, new Quaternion(0, 0, 0, 0));
        }

        for (int i = 0; i < 4; i++)
        {
            Vector3 position = new Vector3(-10 + (1.6f * i), -1f, 0);

            Instantiate(block, position, new Quaternion(0, 0, 0, 0));


            position = new Vector3(-10 + (1.6f * (i + 8)), -1f, 0);

            Instantiate(block, position, new Quaternion(0, 0, 0, 0));

            position = new Vector3(-10 + (1.6f * (i + 4)), 2.5f, 0);

            Instantiate(block, position, new Quaternion(0, 0, 0, 0));


        }

        for (int i = 0; i < 3; i++)
        {

            Vector3 position = new Vector3(-10 + (1.6f * (i + 12)), 2.5f, 0);

            Instantiate(block, position, new Quaternion(0, 0, 0, 0));

        }

        for (int i = 0; i < 1; i++)
        {

            Vector3 position = new Vector3(-10 + (1.6f * (i + 13)), 4.2f, 0);

            Instantiate(token, position, new Quaternion(0, 0, 0, 0));

            position = new Vector3(-10 + (1.6f * (i + 9.5f)), 0.75f, 0);

            Instantiate(token, position, new Quaternion(0, 0, 0, 0));

            position = new Vector3(-10 + (1.6f * (i + 16.5f)), -2.75f, 0);

            Instantiate(token, position, new Quaternion(0, 0, 0, 0));


        }

    }
	
	// Update is called once per frame
	void Update () {

	}
}
