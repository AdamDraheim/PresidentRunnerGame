using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewscastCode : MonoBehaviour
{
    //variables
    Text strip; //the text for the news cast
    float spd = 1.0f;

	// Use this for initialization
	void Start()
    {
        strip = GetComponent<Text>();
        ChangeText("This is a text message. Hi! How's it going? Good! Good! That's great! WOW! This is really long. Why are you still reading this?");
        Debug.Log(45 - (GetString().Length * strip.fontSize) / 2);
    }

    //this will change the text displayed
    public void ChangeText(string txt)
    {
        strip.text = txt;
        SetX(740f);
        Debug.Log(45 - (GetString().Length * strip.fontSize) / 2);
    }

    //changes the x-coord of the newscast
    public void SetX(float x)
    {
        strip.transform.position = new Vector3(x, 15f, strip.transform.position.z);
    }
    
    //gets the string of the newscast
    public string GetString()
    {
        return strip.text;
    }
    
    //gets the font size
    public int GetFontSize()
    {
        return strip.fontSize;
    }

    //sets the string of the newscast
    public void SetString(string str)
    {
        strip.text = str;
    }

    //gets the x-coord of the newscast
    public float GetX()
    {
        return strip.transform.position.x;
    }
	
	//moves the newscast object
	public void Update()
    {
        if (GetX() <= 45 - (GetString().Length * strip.fontSize)/2)
        {
            SetX(740f);
        }
        else
        {
            Vector3 pos = new Vector3(spd, 0, 0);
            strip.transform.position -= pos;
        }
    }
}
