using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    public GameObject[] coins;
    public Vector2[] pos;
    public GameObject player;
 
    void Start() {
        coins = new GameObject[GameObject.FindObjectsOfType<Coin>().Length];
        player = GameObject.FindObjectOfType<Player>().gameObject;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        ArrayList distances = new ArrayList();
        print(coins);
        for (int i = 0; i < coins.Length; i++) {
            GameObject coin = coins[i].gameObject;
            pos[i] = coin.transform.position;
            print(coin.transform.position);
            print("Distance to the coin number " + i + " is " + Vector2.Distance(pos[i], player.transform.position));
        }

        // Array.Sort(distances);
        // String str = "";
        // for (int i = 0; i < distances.Length; i++) {
        //     str += distances[i] + "  ";
        // }
        // //print(str);

        // print(distances[0]);
        
    }
}
