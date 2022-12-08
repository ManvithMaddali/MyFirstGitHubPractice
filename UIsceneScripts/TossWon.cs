using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TossWon : MonoBehaviour
{
    private string matchName;
    public InningsInformation inningsInformation;
    public TextMeshProUGUI tossWonText;
    public TextMeshProUGUI matchNameText;
    public TextMeshProUGUI matchNumberText;

    [Header("Animations")]
    public Animator inningsAnimator;
    // Start is called before the first frame update
    void Start()
    {
        inningsInformation.SetData(inningsInformation.inningsInfo.playerName, inningsInformation.inningsInfo.choseTo, inningsInformation.inningsInfo.matchNumber, inningsInformation.inningsInfo.matchName);
        tossWonText.text = inningsInformation.inningsInfo.playerName + inningsInformation.tossWonInformation + inningsInformation.inningsInfo.choseTo;
        matchNumberText.text = inningsInformation.match + inningsInformation.inningsInfo.matchNumber;
        matchNameText.text = inningsInformation.inningsInfo.matchName.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            inningsAnimator.SetTrigger("Open");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            inningsAnimator.SetTrigger("Close");
        }
    }
}
