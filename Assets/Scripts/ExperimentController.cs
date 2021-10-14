using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class ExperimentController : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector director;
    [SerializeField]
    private float[] playableTime;


    private int index;

    void Start()
    {
        index = 0;
        
        
    }

    void Update()
    {

        if (decimal.Round(((decimal)director.time), 2) == decimal.Round((decimal)playableTime[index],2))
        {
            director.Pause();
            index++;
            
        }
        print(" index = " + index + "Time : " + decimal.Round(((decimal)director.time), 2));

    }

    public void PlayExperiment()
    {
        if (index < playableTime.Length)
        //director.time = playableTime[index];
        director.Resume();
        
 
        
    }

}
