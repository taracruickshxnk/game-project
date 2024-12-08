using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{

    public int coinCount;
    public Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        // reset the counter for current points
        coinText.text = coinCount.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Score: " + coinCount.ToString();
    }
}
