using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Player playerScript;
    public GameObject player;
    public Animator coinAnimator;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<Player>();
        coinAnimator = gameObject.GetComponent<Animator>();
    }


    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "Player") {
            playerScript.CollectCoin();
            Debug.Log(playerScript.coinsCollected);

            coinAnimator.SetTrigger("Hit");

            Destroy(this.gameObject, 1f);
        }
    }
}
