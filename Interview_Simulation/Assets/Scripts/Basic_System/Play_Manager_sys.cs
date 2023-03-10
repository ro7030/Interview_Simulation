using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play_Manager_sys : MonoBehaviour
{
    public GameObject EPanel;
    public GameObject GPanel;

    public bool Challenger = false;
    public bool Interviewer = false;

    public bool Gender = false;

    public InputField Enter_Name;
    public string User_Name;

    void Awake()
    {

        DontDestroyOnLoad(gameObject);

    }

    //-----------------------------------------------------------------------//
    //Formal = false / informal = true의 값을 가짐
    public void challenger_dress_Formal()
    {
        Challenger = false;
    }

    public void challenger_dress_informal()
    {
        Challenger = true;
    }

    public void interviewer_dress_Formal()
    {
        Interviewer = false;
    }

    public void interviewer_dress_informal()
    {
        Interviewer = true;
    }

    public void Next_Panel()
    {
        EPanel.SetActive(false);
        GPanel.SetActive(true);
    }
    //-----------------------------------------------------------------------//
    //성별이 남자의 경우 false 여성의 경우 true

    public void Name()
    {
        User_Name = Enter_Name.text;
    }

    public void Man()
    {
        Gender = false;
        SceneManager.LoadScene(1);
    }

    public void Woman()
    {
        Gender = true;
        SceneManager.LoadScene(2);
    }
    //-----------------------------------------------------------------------//
}
