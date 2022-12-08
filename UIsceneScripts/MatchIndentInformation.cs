using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIndentInformation : MonoBehaviour
{
    public struct matchIndentInfo
    {
        public int matchNumber;
        public string player1Name;
        public string player2Name;
        public string stadiumName;
    }
    public matchIndentInfo matchIndent;
    private void Awake()
    {
        matchIndent.matchNumber = 1;
        matchIndent.player1Name = "MANVITH";
        matchIndent.player2Name = "VENKAT";
        matchIndent.stadiumName = "DUBAI";
    }
    public void SetData(matchIndentInfo myMatchIndentInfo)
    {
        myMatchIndentInfo.matchNumber = 1;
        myMatchIndentInfo.player1Name = "MANVITH";
        myMatchIndentInfo.player2Name = "VENKAT";
        myMatchIndentInfo.stadiumName = "STADIUM 5";

        matchIndent = myMatchIndentInfo;
    }
}
