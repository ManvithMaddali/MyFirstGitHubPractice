using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInformation : MonoBehaviour
{
    public TargetInfo targetInfo;
    [HideInInspector]
    public string target="TARGET";
    [HideInInspector]
    public string overs="OVERS ";
    [HideInInspector]
    public string runRateInformation = "REQUIRED RUN RATE ";
    [HideInInspector]
    public string perOverString = " PER OVER";
    [HideInInspector]
    public string match = "MATCH ";
    public struct TargetInfo
    {
        public int score;
        public int oversCount;
        public float runRatePerOver;
        public int matchNumber;
    }
    public void SetData(int score,int oversCount,float reqRunRatePerOver,int matchNumber)
    {
        targetInfo.score = 194;
        targetInfo.oversCount = 20;
        targetInfo.runRatePerOver = 9.7f;
        targetInfo.matchNumber = 1;
        score = targetInfo.score;
        //oversCount = targetInfo.oversCount;
        reqRunRatePerOver = targetInfo.runRatePerOver;
        matchNumber = targetInfo.matchNumber;
    }
    private void Start()
    {
        SetData(targetInfo.score, targetInfo.oversCount, targetInfo.runRatePerOver, targetInfo.matchNumber);
    }
}
