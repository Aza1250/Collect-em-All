using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject player;
    public float followSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Slerp(transform.position,
                                                new Vector3(player.transform.position.x, player.transform.position.y, -10),
                                                followSpeed * Time.deltaTime);
    }
}
