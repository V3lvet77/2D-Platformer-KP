using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public float HealingValue = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Health_Component>().AddHealth(HealingValue);
        Destroy(gameObject);
    }

}