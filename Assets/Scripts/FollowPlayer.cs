using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    

    public Vector3 offset;
    [Range(0.01f,1.0f)]
    public float SmoothFactor = 0.5f;

    public bool lookAtPlayer = false;
    private void Start()
    {
        offset = transform.position - player.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = player.position + offset;
        //Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        //  Debug.Log(player.position);
        transform.position = Vector3.Slerp(transform.position,newPos,SmoothFactor);

        if (lookAtPlayer)
        transform.LookAt(player);
    }
}
