using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Toglle : MonoBehaviour
{
    public Data data;

    public TextMeshProUGUI priceText1;
    public TextMeshProUGUI priceText2;
    public TextMeshProUGUI priceText3;
    public TextMeshProUGUI goldCardCheckpoint1Text;
    public TextMeshProUGUI goldCardCheckpoint2Text;
    public TextMeshProUGUI goldCardCheckpoint3Text;
    public TextMeshProUGUI diamondCardCheckpoint1Text;
    public TextMeshProUGUI diamondCardCheckpoint2Text;
    public TextMeshProUGUI diamondCardCheckpoint3Text;
    public TextMeshProUGUI platinumCardCheckpoint1Text;
    public TextMeshProUGUI platinumCardCheckpoint2Text;
    public TextMeshProUGUI platinumCardCheckpoint3Text;

    // Start is called before the first frame update
    void Start()
    {
        //goldCardCheckpoint1Text.text = data.dataForCurrentUI.goldCardCheckpoint1;     
    }

    // Update is called once per frame
    void Update()
    {
        //if (GetComponent<Toggle>().isOn==false)
        //{
        //    priceText1.text = goldCardPriceText;
        //    priceText2.text = diamondCardPriceText;
        //    priceText3.text = platinumCardPriceText;
        //}
        //if (GetComponent<Toggle>().isOn == true)
        //{
        //    priceText1.text = goldCardPriceTextToggleChangedValue;
        //    priceText2.text = diamondCardPriceTextToggleChangedValue;
        //    priceText3.text = platinumCardPriceTextToggleChangedValue;
        //}
    }
}
