using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Toss : MonoBehaviour
{
    private string matchName;
    public TossInformation tossInformation;
    public TextMeshProUGUI tossWonText;
    public TextMeshProUGUI matchNameText;
    public TextMeshProUGUI matchNumberText;

    
    // Start is called before the first frame update
    void Start()
    {
        tossInformation.SetData(tossInformation.inningsInfo.playerName, tossInformation.inningsInfo.choseTo, tossInformation.inningsInfo.matchNumber, tossInformation.inningsInfo.matchName);
        tossWonText.text = tossInformation.inningsInfo.playerName + tossInformation.tossWonInformation + tossInformation.inningsInfo.choseTo;
        matchNumberText.text = tossInformation.match + tossInformation.inningsInfo.matchNumber;
        matchNameText.text = tossInformation.inningsInfo.matchName.ToString();
    }
}
