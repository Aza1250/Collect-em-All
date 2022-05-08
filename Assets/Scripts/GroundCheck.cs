using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    Player playerScript;
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GetComponentInParent<Player>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            playerScript.isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
            playerScript.isGrounded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Head") {
            enemy = other.transform.parent.gameObject;
            enemy.GetComponent<Animator>().SetTrigger("Hit");
            enemy.GetComponent<Enemy>().speed = 0f;
            Destroy(enemy, 1.5f);
        }
    }


}
