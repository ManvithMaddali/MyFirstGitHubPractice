using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public struct DataForCurrentUI
    {
        public string goldCardPrice;
        public string diamondCardPrice;
        public string platinumCardPrice;

        public string goldCardTitle;
        public string diamondCardTitle;
        public string platinumCardTitle;

        public string goldCardCheckpoint1;
        public string goldCardCheckpoin2;
        public string goldCardCheckpoint3;

        public string diamondCardCheckpoint1;
        public string diamondCardCheckpoint2;
        public string diamondCardCheckpoint3;

        public string platinumCardCheckpoint1;
        public string platinumCardCheckpoint2;
        public string platinumCardCheckpoint3;
        

    }
    [HideInInspector]
    public DataForCurrentUI dataForCurrentUI;
    private string goldCardPrice;
    private void Start()
    {
        dataForCurrentUI.goldCardCheckpoint1 = "1000 G.B CLOUD SPACE";
        dataForCurrentUI.goldCardCheckpoin2 = "UNLIMITED SERVER REQUESTS";
        dataForCurrentUI.goldCardCheckpoint3 = "UNLIMITED SPACE";


        dataForCurrentUI.diamondCardCheckpoint1 = "1000 G.B CLOUD SPACE";
        dataForCurrentUI.diamondCardCheckpoint2 = "UNLIMITED SERVER REQUESTS";
        dataForCurrentUI.diamondCardCheckpoint3 = "UNLIMITED SPACE";


        dataForCurrentUI.platinumCardCheckpoint1 = "1000 G.B CLOUD SPACE";
        dataForCurrentUI.platinumCardCheckpoint2 = "UNLIMITED SERVER REQUESTS";
        dataForCurrentUI.platinumCardCheckpoint3 = "UNLIMITED SPACE";

        dataForCurrentUI.goldCardPrice = "20$";
    }
    public Data(string goldCardPrice,string diamondCardPrice,string platinumCardPrice,string goldCardCheckpoint1,string goldCardCheckpoint2, string goldCardCheckpoint3, string diamondCardCheckpoint2)
    {

    }
}
