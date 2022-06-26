using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;

    void Start() {
        //InvokeRepeating("Shoot", 1.0f, 3.0f);
    }

    void Update() {
        Vector2 direction = (player.transform.position - this.transform.position) * 50;
        
        GameObject bulletCopy = Instantiate(bullet, this.transform.position, Quaternion.identity);

        bulletCopy.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y);
        Destroy(bulletCopy, 2.5f);
    }
}

