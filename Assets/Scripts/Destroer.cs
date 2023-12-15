using UnityEngine;

public class Destroer : MonoBehaviour
{
    public float DestroyTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    } 
}
