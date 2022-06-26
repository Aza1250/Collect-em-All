using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    GameObject player;
    public Text healthText;
    public Text timerText;
    public Text coinsCollectedText;
    public float time;
    int totalCoins;

    void Awake() {
        // Don't destroy the timer text
        DontDestroyOnLoad(transform.gameObject);
        totalCoins = GameObject.FindObjectsOfType<Coin>().Length;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        healthText = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
        coinsCollectedText = this.gameObject.transform.GetChild(2).gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + player.GetComponent<Player>().health.ToString();
        //print(totalCoins + "  " + GameObject.FindObjectsOfType<Coin>().Length);
        coinsCollectedText.text = "Coins: " +  (totalCoins - GameObject.FindObjectsOfType<Coin>().Length);
        if (Input.GetKeyDown(KeyCode.RightShift)) time += Time.deltaTime * 2;
        else time += Time.deltaTime;
        timerText.text = "Time: " + time.ToString("0.00");
    }
}
