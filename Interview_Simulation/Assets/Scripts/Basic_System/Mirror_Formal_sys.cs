using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mirror_Formal_sys : MonoBehaviour
{
    public GameObject Formal_Avater;
    public GameObject Informal_Avater;

    public GameObject Panel;

    public bool Challenger_1 = false;
    public bool Interviewer_1 = false;
    public bool Gender_1 = false;

    public bool Panel_off = false;

    GameObject obj;

    public void Awake()
    {
        obj = GameObject.Find("GameManager");

        Challenger_1 = obj.GetComponent<Play_Manager_sys>().Challenger;
        Interviewer_1 = obj.GetComponent<Play_Manager_sys>().Interviewer;
        Gender_1 = obj.GetComponent<Play_Manager_sys>().Gender;
    }

    // Start is called before the first frame update
    void Start()
    {
        if(Challenger_1 == false)
        {
            Formal_Avater.SetActive(true);
        }
        else if(Challenger_1 == true)
        {
            Informal_Avater.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && Panel_off == true)
        {
            if(Gender_1 == false && Challenger_1 == false && Interviewer_1 == false)
            {
                //성별 남자 도전자 정장 면접관 정장
                SceneManager.LoadScene(3);
            }
            else if(Gender_1 == false && Challenger_1 == false && Interviewer_1 == true)
            {
                //성별 남자 도전자 정장 면접관 캐주얼
                SceneManager.LoadScene(4);
            }
            else if (Gender_1 == false && Challenger_1 == true && Interviewer_1 == false)
            {
                //성별 남자 도전자 캐주얼 면접관 정장
                SceneManager.LoadScene(5);
            }
            else if (Gender_1 == false && Challenger_1 == true && Interviewer_1 == true)
            {
                //성별 남자 도전자 캐주얼 면접관 캐주얼
                SceneManager.LoadScene(6);
            }
            else if (Gender_1 == true && Challenger_1 == false && Interviewer_1 == false)
            {
                //성별 여성 도전자 정장 면접관 정장
                SceneManager.LoadScene(7);
            }
            else if (Gender_1 == true && Challenger_1 == false && Interviewer_1 == true)
            {
                //성별 여성 도전자 정장 면접관 캐주얼
                SceneManager.LoadScene(8);
            }
            else if (Gender_1 == true && Challenger_1 == true && Interviewer_1 == false)
            {
                //성별 여성 도전자 캐주얼 면접관 정장
                SceneManager.LoadScene(9);
            }
            else if (Gender_1 == true && Challenger_1 == true && Interviewer_1 == true)
            {
                //성별 여성 도전자 캐주얼 면접관 캐주얼
                SceneManager.LoadScene(10);
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Panel_off = true;
            Panel.SetActive(false);
        }

    }
}
