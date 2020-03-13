using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Vector3 offset;

    [SerializeField] Transform player;

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition = player.localPosition + offset;
        transform.LookAt(player, Vector3.up);
    }
}
