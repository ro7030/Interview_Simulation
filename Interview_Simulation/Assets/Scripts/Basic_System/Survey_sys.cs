using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survey_sys : MonoBehaviour
{
    public GameObject SPanel;
    
    public AudioSource audioSource;

    public bool SPanel_off = false;
    public bool Q1 = false;
    public bool Q2 = false;
    public bool Q3 = false;
    public bool Q4 = false;
    public bool Q5 = false;
    public bool Finish = false;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && SPanel_off == false && Q1 == false && Q2 == false && Q3 == false && Q4 == false && Q5 == false && Finish == false)
        {
            SPanel_off = true;
            SPanel.SetActive(false);
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && SPanel_off == true && Q1 == false && Q2 == false && Q3 == false && Q4 == false && Q5 == false && Finish == false)
        {
            audioSource.clip = Resources.Load<AudioClip>("Q1");
            audioSource.Play();
            Q1 = true;
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && SPanel_off == true && Q1 == true && Q2 == false && Q3 == false && Q4 == false && Q5 == false && Finish == false)
        {
            audioSource.clip = Resources.Load<AudioClip>("Q2");
            audioSource.Play();
            Q2 = true;
        }
        else if(OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && SPanel_off == true && Q1 == true && Q2 == true && Q3 == false && Q4 == false && Q5 == false && Finish == false)
        {
            audioSource.clip = Resources.Load<AudioClip>("Q3");
            audioSource.Play();
            Q3 = true;
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && SPanel_off == true && Q1 == true && Q2 == true && Q3 == true && Q4 == false && Q5 == false && Finish == false)
        {
            audioSource.clip = Resources.Load<AudioClip>("Q4");
            audioSource.Play();
            Q4 = true;
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && SPanel_off == true && Q1 == true && Q2 == true && Q3 == true && Q4 == true && Q5 == false && Finish == false)
        {
            audioSource.clip = Resources.Load<AudioClip>("Q5");
            audioSource.Play();
            Q5 = true;
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && SPanel_off == true && Q1 == true && Q2 == true && Q3 == true && Q4 == true && Q5 == true && Finish == false)
        {
            audioSource.clip = Resources.Load<AudioClip>("Finish");
            audioSource.Play();
            Finish = true;
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) && SPanel_off == true && Q1 == true && Q2 == true && Q3 == true && Q4 == true && Q5 == true && Finish == true)
        {
            audioSource.clip = Resources.Load<AudioClip>("End");
            audioSource.Play();
        }
    }
}
