using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsScript : MonoBehaviour
{





    public Text MycoinsText;
    private int CoinsNum;

    void Start()
    {
        CoinsNum = 0;
        MycoinsText.text = "Coins: " + CoinsNum;
     }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "Mycoin")
        {
            CoinsNum += 1;
            Destroy(Coin.gameObject);
            MycoinsText.text = "Coins" + CoinsNum;
        }
    }

}
