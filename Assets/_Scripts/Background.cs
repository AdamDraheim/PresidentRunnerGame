using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour {


    public Sprite utopia, dystopia;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {



    }

    void SelectBackground(int value)
    {

        if (value > 2)
        {
            GetComponent<Image>().sprite = utopia;
        }
        else{
            GetComponent<Image>().sprite = dystopia;

        }
    }
}
