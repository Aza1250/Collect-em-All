using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    GameObject player;
    Text healthText;
    public Text timerText;
    public float time;

    void Awake() {
        // Don't destroy the timer text
        DontDestroyOnLoad(transform.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        healthText = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + player.GetComponent<Player>().health.ToString();
        if (Input.GetKeyDown(KeyCode.RightShift)) time += Time.deltaTime * 2;
        else time += Time.deltaTime;
        timerText.text = "Time: " + time.ToString("0.00");
    }
}
