using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartCode : MonoBehaviour
{
    //variables
    public Button button; //the start button

    // Use this for initialization
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);
    }

    // Update is called on a button click
    void TaskOnClick()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("start was pressed");
    }
}

