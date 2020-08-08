using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float playerSpeed = 50f;
    public float playerJumpSpeed = 20f;
    public float raycastCheck = 0.7f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // walking
        // TODO Make movement snappier
        rigidBody.AddForce(
            Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime,
            0,
            Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime
        );

        // jumping
        bool grounded = Physics.Raycast(transform.position, Vector3.down, raycastCheck);
        if (Input.GetButton("Jump")) {
            // TODO find out why jumping with space bar does not work on Linux
            if (grounded) {
                rigidBody.AddForce(0, playerJumpSpeed, 0, ForceMode.Force);
            }
        }
    }
}
