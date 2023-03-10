using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Voice_Rec_sys : MonoBehaviour
{
    //Microphone.devices[0]�� �̾���
    //Microphone.devices[1]�� ��ŧ���� ����

    public AudioClip Audio;
    int sampleRate = 48000;

    private float[] samples;
    public string file_name;

    public int time_count;

    // Start is called before the first frame update
    void Start()
    {
        samples = new float[sampleRate];
        Audio = Microphone.Start(Microphone.devices[0].ToString(), true, time_count, sampleRate);

        Debug.Log(Microphone.devices[0].ToString());
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Microphone.End(Microphone.devices[0]);
            SavWav.Save("D:\\Unity\\Interview_Simulation_Beta\\Assets\\Voice\\" + file_name, Audio);
        }

    }
}
