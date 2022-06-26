using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public void Start() {
        //print(GameObject.FindObjectsOfType<Coin>().Length);
    }

    void OnTriggerEnter2D(Collider2D other) {
        //print(GameObject.FindObjectsOfType<Coin>().Length);

        if (other.gameObject.tag == "Player" && GameObject.FindObjectsOfType<Coin>().Length == 0) {
            SceneManager.LoadScene("WinScreen");
        }
    }

    void OnDestroy() {
        
    }


}
