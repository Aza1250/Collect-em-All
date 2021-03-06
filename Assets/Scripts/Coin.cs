using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coin : MonoBehaviour
{
    private Player playerScript;
    public Animator coinAnimator;
    public float distanceToPlayer;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>().gameObject;
        playerScript = GameObject.FindWithTag("Player").GetComponent<Player>();
        coinAnimator = gameObject.GetComponent<Animator>();
    }
    
    void Update() {
        distanceToPlayer = Vector2.Distance(player.transform.position, transform.position);
    }


    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "Player") {
            playerScript.coinsCollected++;
            Debug.Log(playerScript.coinsCollected);

            coinAnimator.SetTrigger("Hit");

            Destroy(this.gameObject, 1f);
        }
    }
}
