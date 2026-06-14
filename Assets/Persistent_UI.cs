using UnityEngine;

public class Persistent_UI : MonoBehaviour
{
private void Awake()
{
DontDestroyOnLoad(gameObject);
}
}
