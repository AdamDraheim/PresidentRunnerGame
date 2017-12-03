using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Token : MonoBehaviour {

    // Use this for initialization
    private GameObject player;
    private float difference = 7f;

    private int change = 5;

    private string statToChange = "";

    public Sprite food, military, laws, land, taxes, infrastructure;

    private SpriteRenderer sr;

    public GameObject statistics;

    string[] sendInfo = new string[2];


    // Use this for initialization
    void Start()
    {

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");

        }

        sr = GetComponent<SpriteRenderer>();

        ResetCategory();

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x - player.transform.position.x < -difference)
        {
            Vector3 position = new Vector3(transform.position.x + (1.6f * 15), transform.position.y, 0);

            transform.position = position;

            ResetCategory();

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) {

            Vector3 position = new Vector3(transform.position.x + (1.6f * 15), transform.position.y, 0);

            transform.position = position;

            statistics.SendMessage("AdjustStats", sendInfo);

            ResetCategory();


        }

    }

    void ResetCategory()
    {

        if(Random.Range(0, 2) == 0)
        {
            change = 10;
            sr.color = new Color(0, 200, 0);
        }
        else
        {
            change = -10;
            sr.color = new Color(200, 0, 0);

        }

        int toChange = Random.Range(0, 5);

        switch (toChange)
        {
            case 0:
                statToChange = "Food";
                sr.sprite = food;
                break;
            case 1:
                statToChange = "Military";
                sr.sprite = military;
                break;
            case 2:
                statToChange = "Taxes";
                sr.sprite = taxes;
                break;
            case 3:
                statToChange = "Laws";
                sr.sprite = laws;
                break;
            case 4:
                statToChange = "Land";
                sr.sprite = land;
                break;
            case 5:
                statToChange = "Infrastructure";
                sr.sprite = infrastructure;
                break;
        }

        sendInfo[0] = statToChange;
        sendInfo[1] = change + "";

    }
}
