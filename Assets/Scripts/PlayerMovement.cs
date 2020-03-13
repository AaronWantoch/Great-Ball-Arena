using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Transform center;

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
        Vector3 direction = (center.position - transform.position).normalized;
        Vector3 right = Vector3.Cross(direction, Vector3.up).normalized;

        Debug.Log(direction);
        Debug.DrawRay(transform.position, direction);

        float speedPerFrame =speed * Time.deltaTime;
        rigidbody.AddForce(new Vector3
            (CrossPlatformInputManager.GetAxis("Horizontal") * speedPerFrame * right.x,
            0,
            CrossPlatformInputManager.GetAxis("Horizontal") * speedPerFrame * right.z));
        rigidbody.AddForce(new Vector3
            (CrossPlatformInputManager.GetAxis("Vertical") * speedPerFrame * direction.x,
            0,
            CrossPlatformInputManager.GetAxis("Vertical") * speedPerFrame * direction.z));
    }
}
