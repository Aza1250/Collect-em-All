using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    bool facingRight;
    public float jumpForce = 5f;
    public bool isGrounded = false;
    public int jumpsAvailable = 2;
    public int coinsCollected;
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        coinsCollected = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightShift)) {
            Time.timeScale = 0.1f;
        }
        if (Input.GetKeyUp(KeyCode.RightShift)) {
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (facingRight) rb.velocity = Vector2.right * 20f;
            else rb.velocity = Vector2.left * 20f;
            Invoke("ResetVel", 0.2f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector2(1, 1);
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            facingRight = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector2(-1, 1);
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            facingRight = false;
        }

    

        if (Input.GetKeyDown(KeyCode.Space) && jumpsAvailable > 0)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Invoke("DecrementJumps", 0.02f);
        } else if (Input.GetKey(KeyCode.Space) && jumpsAvailable == 0 && rb.velocity.y < 0) {
            rb.AddForce(Vector2.up * (rb.velocity.y * -0.025f), ForceMode2D.Impulse);
        }

        if (isGrounded)
        {
            jumpsAvailable = 2;
        }
    }
    void ResetVel()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }

    void DecrementJumps()
    {
        jumpsAvailable--;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            TakeDamage(1);
        }
        if (other.gameObject.tag == "Kill") {
            TakeDamage();
        }
    }

    void TakeDamage(int dmg = 50) {
        health -= dmg;
        print(health);
        if (health <= 0) {
            SceneManager.LoadScene("LoseScreen");
            Destroy(gameObject);
        }
    }

}

