using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -11);
    // Update is called once per frame
    void LateUpdate()
    {
        // Camera follows vehicle and adds an offset
        transform.position = player.transform.position + offset;
    }
}
