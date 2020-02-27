using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        float speedPerFrame = speed * Time.deltaTime;
        rigidbody.AddForce(
            CrossPlatformInputManager.GetAxis("Horizontal") * speedPerFrame,
            0,
            CrossPlatformInputManager.GetAxis("Vertical") * speedPerFrame);
    }
}
