using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public PlayerStatsInformation playerStatsInformation;

    [Header("Text")]
    public TextMeshProUGUI numberOfMatchesText;
    public TextMeshProUGUI numberOfRunsText;
    public TextMeshProUGUI averageText;
    public TextMeshProUGUI numberOfFiftiesText;
    public TextMeshProUGUI numberOfHundredsText;
    public TextMeshProUGUI strikeRateText;
    // Start is called before the first frame update
    
    void Start()
    {

        playerStatsInformation.SetData(playerStatsInformation.playerMetaCareerStats);
        numberOfMatchesText.text = playerStatsInformation.playerMetaCareerStats.numberOfMatches.ToString();
        numberOfRunsText.text = playerStatsInformation.playerMetaCareerStats.numberOfRuns;
        averageText.text = playerStatsInformation.playerMetaCareerStats.average.ToString();
        numberOfFiftiesText.text = playerStatsInformation.playerMetaCareerStats.numberOfFifties.ToString();
        numberOfHundredsText.text = playerStatsInformation.playerMetaCareerStats.numberOfHundreds.ToString();
        strikeRateText.text = playerStatsInformation.playerMetaCareerStats.strikeRate.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
