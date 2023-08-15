using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public int NumberOfCoins;
    [SerializeField] TextMeshProUGUI _text;

    private void Start()
    {
        NumberOfCoins = Progress.Instance.Coins;
        _text.text = NumberOfCoins.ToString();

    }

    public void AddOne()
    {
        NumberOfCoins++;
        _text.text= NumberOfCoins.ToString();
    }

    public void SaveToProgress()
    {
        Progress.Instance.Coins = NumberOfCoins;
    }

    public void SpendMoney(int value)
    {
        NumberOfCoins -= value;
        _text.text = NumberOfCoins.ToString();

    }
}
