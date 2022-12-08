using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2HMetaRankingInformation : MonoBehaviour
{
    public struct headToHeadMetaRank
    {
        public int player1MetaRank;
        public int player2MetaRank;
        public string player1Name;
        public string player2Name;
        public string stadiumName;
        public string h2hMetaRankTitle;
    }
    public headToHeadMetaRank metaRankInfo;
    public void SetData(headToHeadMetaRank h2hMetaRank)
    {
        h2hMetaRank.player1MetaRank = 10;
        h2hMetaRank.player2MetaRank = 7;
        h2hMetaRank.player1Name = "VENKAT";
        h2hMetaRank.player2Name = "VINOD";
        h2hMetaRank.stadiumName = "STADIUM 5";
        h2hMetaRank.h2hMetaRankTitle = "HEAD TO HEAD";

        metaRankInfo = h2hMetaRank;
    }
}
