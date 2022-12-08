using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerStatsInformation :MonoBehaviour
{
    public struct playerStats
    {
        public int numberOfMatches;
        public string numberOfRuns;
        public float average;
        public int numberOfFifties;
        public int numberOfHundreds;
        public float strikeRate;
    }
    public playerStats playerMetaCareerStats;
    
    public void SetData(playerStats myPlayerStats)
    {
        myPlayerStats.numberOfMatches=134;
        myPlayerStats.numberOfRuns = "5,120";
        myPlayerStats.average = 46.55f;
        myPlayerStats.numberOfFifties = 32;
        myPlayerStats.numberOfHundreds = 11;
        myPlayerStats.strikeRate = 88.55f;

        playerMetaCareerStats = myPlayerStats;
        
    }

}
