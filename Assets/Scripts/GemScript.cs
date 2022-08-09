using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemScript : MonoBehaviour
{

    public Text MygemsText;
    private int GemsNum;

    void Start()
    {
        GemsNum = 0;
        MygemsText.text = "Gems: " + GemsNum;
    }

    private void OnTriggerEnter2D(Collider2D Gem)
    {
        if (Gem.tag == "Mygem")
        {
            GemsNum += 1;
            Destroy(Gem.gameObject);
            MygemsText.text = "Gems" + GemsNum;
        }
    }

}
