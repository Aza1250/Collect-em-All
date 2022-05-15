using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sus : MonoBehaviour
{
    public GameObject imposter;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", 0f, Random.Range(0.25f, 2.5f));
    }

    public void Spawner() {
        GameObject obj; 

        obj = Instantiate(imposter, new Vector2(Random.Range(-9, 9), Random.Range(-4.5f, 4.5f)), Quaternion.identity);

        obj.transform.localScale = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
    }
    
}
