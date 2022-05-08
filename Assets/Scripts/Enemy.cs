using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float leftMax;
    public float rightMax;
    public float originalX;
    public float direction = 1f;
    // Start is called before the first frame update
    void Start()
    {
        originalX = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
       if (direction > 0.0f && transform.position.x >= rightMax + originalX) {
           transform.localScale = new Vector2(-2, 2);
           direction = -1.0f;
       }
       if (direction < 0.0f && transform.position.x <= originalX - leftMax) {
           transform.localScale = new Vector2(2, 2);
           direction = 1.0f;
       }

       transform.Translate(speed * Time.deltaTime * new Vector2(direction, 0));

    }
}
