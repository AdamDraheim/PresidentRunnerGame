using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewscastManager : MonoBehaviour {
    //variables
    NewscastCode[] textUis = new NewscastCode[3]; //the text UIs in the game
    NewscastCode baseText; //the base Text object that will be copied
    string news; //the newscast

	// Use this for initialization
	void Start() {
        baseText = GetComponent<NewscastCode>();
        //Debug.Log(baseText.text);
        textUis[0] = Instantiate(baseText);
        textUis[0].SetX(740);
        textUis[1] = Instantiate(baseText);
        textUis[1].SetX((textUis[0].GetX() + (textUis[0].GetString().Length * textUis[0].GetFontSize())));
        textUis[2] = Instantiate(baseText);
        textUis[2].SetX((textUis[1].GetX() + (textUis[1].GetString().Length * textUis[1].GetFontSize())));
        Destroy(baseText);
    }

    //changes the newscast info
    public void ChangeNewscast(string txt)
    {
        news = txt;
    }
	
	// Update is called once per frame
	void Update() {
		/*for (int i = 0; i < textUis.Length; i++)
        {
            NewscastCode nc_code = textUis[i];
            nc_code.Move();
            if (nc_code.GetX() <= 45 - textUis[i].GetString().Length * textUis[i].GetFontSize())
            {
                if ((i < (textUis.Length - 1) && i > 0))
                {
                    nc_code.SetX((textUis[i-1].GetString().Length * textUis[i - 1].GetFontSize()));
                }
                else
                {
                    if (i == (textUis.Length - 1))
                    {
                        nc_code.SetX((textUis[0].GetString().Length * textUis[0].GetFontSize()));
                    }
                    else
                    {
                        nc_code.SetX((textUis[textUis.Length - 1].GetString().Length * textUis[textUis.Length - 1].GetFontSize()));
                    }
                }
                if (news != textUis[i].GetString())
                {
                    nc_code.ChangeText(news);
                }
            }
        }*/
    }
}
