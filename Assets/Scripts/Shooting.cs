using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Vector3 mousePosition; //change to player GameObject
    public GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //not needed
        Vector2 direction = mousePosition - transform.position; //player.transform.position instead of mousePosition
        
        if (Input.GetMouseButtonDown(0)) { //not needed
            GameObject bulletCopy = Instantiate(bullet, this.transform.position, Quaternion.identity);
            bulletCopy.transform.rotation = Quaternion.identity;

            bulletCopy.GetComponent<Rigidbody2D>().AddForce(direction * 100);
            Destroy(bulletCopy, 2.5f);
        }
    }
}
