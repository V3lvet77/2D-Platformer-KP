using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float points = 1;


private void OnTriggerEnter2D(Collider2D collision)
{
    //Dodac pkt grazcowi
    collision.GetComponent<CoinComponent>().AddPoints(points);
    Destroy(gameObject);
}
}