using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TossInformation : MonoBehaviour
{
    [HideInInspector]
    public string tossWonInformation = " WON TOSS & CHOSE TO ";
    [HideInInspector]
    public string match = "MATCH ";
    public struct InningsInfo
    {
        public string playerName;
        public string choseTo;
        public int matchNumber;
        public string matchName;
    }
    public InningsInfo inningsInfo;
    private void Awake()
    {
        inningsInfo.playerName = "VENKAT";
        inningsInfo.choseTo = "BOWL";
        inningsInfo.matchNumber = 1;
        inningsInfo.matchName = "MSS TOURNAMENT";
    }
    public void SetData(string playerName, string choseToBatOrBowl, int matchNum, string matchName)
    {
        playerName = inningsInfo.playerName;
        choseToBatOrBowl = inningsInfo.choseTo;
        matchNum = inningsInfo.matchNumber;
        matchName = inningsInfo.matchName;
    }
}
