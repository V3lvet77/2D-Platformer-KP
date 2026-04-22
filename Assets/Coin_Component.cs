using UnityEngine;

public class CoinComponent : MonoBehaviour
{
    private float points;

    public delegate void CoinEventHandler(float currentPoints, float amountChanged);
    public event CoinEventHandler CoinAmountChanged;

    private void Start()
    {
        AddPoints(0);
    }
    private void Update()
    {
        
    }
    public void AddPoints(float amount)
    {
        points += amount;
        CoinAmountChanged?.Invoke(points,amount);
    }

}
