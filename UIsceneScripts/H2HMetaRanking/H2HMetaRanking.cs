using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class H2HMetaRanking : MonoBehaviour
{
    public H2HMetaRankingInformation h2HMetaRankingInformation;

    public TextMeshProUGUI player1MetaRankText;
    public TextMeshProUGUI player2MetaRankText;
    public TextMeshProUGUI player1NameText;
    public TextMeshProUGUI player2NameText;
    public TextMeshProUGUI stadiumNameText;
    public TextMeshProUGUI headToHeadTitle;

    public const string stadiumInfo = "LIVE FROM ";

    private void Start()
    {
        h2HMetaRankingInformation.SetData(h2HMetaRankingInformation.metaRankInfo);
        player1MetaRankText.text = h2HMetaRankingInformation.metaRankInfo.player1MetaRank.ToString();
        player2MetaRankText.text = h2HMetaRankingInformation.metaRankInfo.player2MetaRank.ToString();
        player1NameText.text = h2HMetaRankingInformation.metaRankInfo.player1Name.ToString();
        player2NameText.text = h2HMetaRankingInformation.metaRankInfo.player2Name.ToString();
        stadiumNameText.text = stadiumInfo+h2HMetaRankingInformation.metaRankInfo.stadiumName.ToString();
        headToHeadTitle.text = h2HMetaRankingInformation.metaRankInfo.h2hMetaRankTitle;
    }
}
