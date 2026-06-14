using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UI_Coin_Display : MonoBehaviour 
{
    public CoinComponent coinComp;
    public TextMeshProUGUI coinText;

private void Awake()
{
    coinComp.CoinAmountChanged += CoinComp_CoinAmountChanged;
}
private void CoinComp_CoinAmountChanged(float currentPoints, float amountChanged)
{
    coinText.text="Coins: " + currentPoints.ToString();
}
}