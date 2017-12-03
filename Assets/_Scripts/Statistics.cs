using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour {

    private int FOOD = 50;
    private int LAWS = 50;
    private int TAXES = 50;
    private int MILITARY = 50;
    private int LAND = 50;
    private int INFRASTRUCTURE = 50;

    private int FOOD_CHANGE = -5;
    private int LAWS_CHANGE = -5;
    private int TAX_CHANGE = -5;
    private int MILITARY_CHANGE = -5;
    private int LAND_CHANGE = -5;
    private int INFRASTRUCTURE_CHANGE = -5;

    bool[] goodValues = new bool[6];

    public int lawsPassed = 0;

    public GameObject food, laws, tax, mil, land, infra;

    public GameObject background;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        food.transform.localScale = new Vector3(0.7f / (100f / FOOD), .75f, 1);
        laws.transform.localScale = new Vector3(0.7f / (100f / LAWS), .75f, 1);
        tax.transform.localScale = new Vector3(0.7f / (100f / TAXES), .75f, 1);
        infra.transform.localScale = new Vector3(0.7f / (100f / INFRASTRUCTURE), .75f, 1);
        mil.transform.localScale = new Vector3(0.7f / (100f / MILITARY), .75f, 1);
        land.transform.localScale = new Vector3(0.7f / (100f / LAND), .75f, 1);

        if (FOOD >= 25 && FOOD <= 75)
        {
            food.GetComponent<Image>().color = Color.green;
            goodValues[0] = true;

        }
        else
        {
            food.GetComponent<Image>().color = Color.red;
            goodValues[0] = false;

        }

        if (LAWS >= 25 && LAWS <= 75)
        {
            laws.GetComponent<Image>().color = Color.green;
            goodValues[1] = true;

        }
        else
        {
            laws.GetComponent<Image>().color = Color.red;
            goodValues[1] = false;


        }

        if (TAXES >= 25 && TAXES <= 75)
        {

            goodValues[2] = true;

            tax.GetComponent<Image>().color = Color.green;

        }
        else
        {
            tax.GetComponent<Image>().color = Color.red;
            goodValues[2] = false;

        }
        if (LAND >= 25 && LAND <= 75)
        {
            land.GetComponent<Image>().color = Color.green;
            goodValues[3] = true;


        }
        else
        {
            land.GetComponent<Image>().color = Color.red;
            goodValues[3] = false;

        }
        if (MILITARY >= 25 && MILITARY <= 75)
        {
            mil.GetComponent<Image>().color = Color.green;
            goodValues[4] = true;


        }
        else
        {
            mil.GetComponent<Image>().color = Color.red;
            goodValues[4] = false;

        }
        if (INFRASTRUCTURE >= 25 && INFRASTRUCTURE <= 75)
        {
            infra.GetComponent<Image>().color = Color.green;
            goodValues[5] = true;


        }
        else
        {
            infra.GetComponent<Image>().color = Color.red;
            goodValues[5] = false;

        }

        CalculatePolicies();
    }

    void AdjustStats(string[] info)
    {

        int change = int.Parse(info[1]);


        switch (info[0])
        {
            
            case "Food":

                FOOD += change;

                FOOD_CHANGE = (change / 2);

                break;

            case "Laws":

                LAWS += change;

                LAWS_CHANGE = (change / 2);
                break;

            case "Taxes":

                TAXES += change;

                TAX_CHANGE = (change / 2);
                break;

            case "Military":

                MILITARY += change;

                MILITARY_CHANGE = (change / 2);
                break;

            case "Land":

                LAND += change;

                LAND_CHANGE = (change / 2);
                break;
            case "Infrasructure":

                INFRASTRUCTURE += change;
                INFRASTRUCTURE_CHANGE = (change / 2);
                break;

        }

        FOOD += FOOD_CHANGE;
        LAWS += LAWS_CHANGE;
        TAXES += TAX_CHANGE;
        LAND += LAND_CHANGE;
        INFRASTRUCTURE += INFRASTRUCTURE_CHANGE;
        MILITARY += MILITARY_CHANGE;

        lawsPassed++;

        CheckStats();
 
   
    }
    

    public void CheckStats()
    {

        if(FOOD >= 100 || FOOD <= 0)
        {

        }

        if (LAWS <= 0 || LAWS >= 100)
        {

        }

        if (TAXES <= 0 || TAXES >= 100)
        {

        }
        if (LAND <= 0 || LAND >= 100)
        {

        }
        if (MILITARY <= 0 || MILITARY >= 100)
        {

        }
        if (INFRASTRUCTURE <= 0 || INFRASTRUCTURE >= 100)
        {

        }
    }

    public void CalculatePolicies()
    {
        int goodPolicies = 0;
        for(int i = 0; i < 6; i++)
        {
            if (goodValues[i])
            {
                goodPolicies++;
            }
        }

        background.SendMessage("SelectBackground", goodPolicies);
        
    }
}
