using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    public ArrayList coins;
    SortedDictionary<int, GameObject> coinDict = new SortedDictionary<int, GameObject>();
    public Vector2[] pos;
    public GameObject player;
 
    void Start() {
        coins = new ArrayList(GameObject.FindObjectsOfType<Coin>());
        player = GameObject.FindObjectOfType<Player>().gameObject;
        // Fill();
    }
    // Update is called once per frame
    void Update()
    {
        coins.Sort();
        print(coins[0]);
        // Sort();
        // GetClosestCoin();

        
    }

    

    // void Fill() {
    //     foreach (Coin coin in coins) {
    //         coinDict.Add(coin.gameObject.transform,coin.gameObject);
    //     }
    // }

    //sort the coins by distance from player
    // void Sort() {
    //     pos = new Vector2[coinDict.Count];
    //     int i = 0;
    //     foreach (KeyValuePair<int, GameObject> pair in coinDict) {
    //         pos[i] = pair.Value.transform.position;
    //         i++;
    //     }
    //     Array.Sort(pos, player.transform.position);
    // }
    
    //get the closest coin to the player
    // public GameObject GetClosestCoin() {
    //     Sort();
    //     return coinDict[pos[0]];
    // }
}
