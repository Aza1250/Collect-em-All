using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Player playerScript;
    public Animator coinAnimator;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindWithTag("Player").GetComponent<Player>();
        coinAnimator = gameObject.GetComponent<Animator>();
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
