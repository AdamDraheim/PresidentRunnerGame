using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float SPEED = 5;
    private float STARTING_SPEED = 5f;
    private Vector3 movement;
    public bool jump = true;

    private float JUMP_SPEED = 500f;
    private float SPEED_INCREASE = 0.1f;
    private Rigidbody2D rb;

    public Sprite walk1, walk2, run, stand;
    private Sprite[] runList = new Sprite[3];
    private int runListChange = 1;
    private int currentDraw = 0;

    private float ANIM_TIME = 0.15f;

    private float MAX_SPEED = 15f;

    private float timer = 0.3f;
 

	// Use this for initialization
	void Start () {

        movement = new Vector3(0, SPEED, 0);
        SPEED = STARTING_SPEED;

        rb = GetComponent<Rigidbody2D>();

        runList[0] = stand;
        runList[1] = walk1;
        runList[2] = run;
        timer = ANIM_TIME;

	}
	
	// Update is called once per frame
	void Update () {

        Anim();

        SPEED += (SPEED_INCREASE * Time.deltaTime);

        if(SPEED > MAX_SPEED)
        {
            SPEED = MAX_SPEED;
        }

        if ((Input.GetKey("w") || Input.GetKey("up")) && !jump)
        {
            
            rb.AddForce(new Vector2(0, JUMP_SPEED));
            jump = true;
        }



        movement = new Vector3(SPEED, 0, 0);

        transform.position += (movement * Time.deltaTime);

        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("Block"))
        {
            jump = false;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Block"))
        {
            jump = true;
        }
    }

    private void Anim()
    {
        SpriteRenderer toDraw = GetComponent<SpriteRenderer>();

            timer -= Time.deltaTime;

            if(timer <= 0)
            {
                currentDraw += runListChange;

                if(currentDraw == 0 || currentDraw == 2)
                {
                    runListChange *= -1;
                }
                timer = ANIM_TIME;
            }

            toDraw.sprite = runList[currentDraw];

        



    }

}
