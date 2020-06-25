using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject playerObject;  // the player object to follow
    public float lerpSpeed = 0.5f;
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(
            transform.position,                         // current camera position
            playerObject.transform.position + offset,   // new position plus our original offset
            lerpSpeed);                                 // the speed of smoothing
    }
}

