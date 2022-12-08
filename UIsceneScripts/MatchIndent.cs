using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MatchIndent : MonoBehaviour
{
    public TextMeshProUGUI match;
    public TextMeshProUGUI player1;
    public TextMeshProUGUI player2;
    public TextMeshProUGUI liveFromWhichStadium;

    public MatchIndentInformation matchIndentInformation;
    private void Start()
    {
        matchIndentInformation.SetData(matchIndentInformation.matchIndent);
        match.text = "MATCH "+matchIndentInformation.matchIndent.matchNumber;
        player1.text = matchIndentInformation.matchIndent.player1Name;
        player2.text = matchIndentInformation.matchIndent.player2Name;
        liveFromWhichStadium.text = "LIVE FROM " + matchIndentInformation.matchIndent.stadiumName;
        
    }
}
