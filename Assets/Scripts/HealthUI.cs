using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    GameObject player;
    Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        healthText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + player.GetComponent<Player>().health.ToString();
    }
}
