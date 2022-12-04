using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    TextMeshProUGUI Coin_Text;

    public int coin = 0;
    // Start is called before the first frame update
    void Start()
    {
        Coin_Text = GetComponent<TextMeshProUGUI>();
        Coin_Text.text = "Coin: 0";
    }

    // Update is called once per frame
    void Update()
    {
        Coin_Text.text = "Coin: " + coin;
    }

    public void Add_coin()
    {
        coin++;
    }
}
