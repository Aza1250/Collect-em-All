using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    GameObject player;
    Text healthText;
    Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        healthText = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
        healthText = this.gameObject.transform.GetChild(1).gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + player.GetComponent<Player>().health.ToString();
    }
}
