using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float playerSpeed = 10f;
    public float playerJumpSpeed = 50f;
    public float raycastCheck = 0.7f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // walking
        rigidBody.AddForce(
            Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime,
            0,
            Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime,
            ForceMode.VelocityChange
        );

        // jumping
        if (Input.GetButton("Jump")) {
            // TODO find out why jumping with space bar does not work on Linux
            bool grounded = Physics.Raycast(transform.position, Vector3.down, raycastCheck);
            if (grounded) {
                rigidBody.AddForce(0, playerJumpSpeed, 0, ForceMode.Force);
            }
        }
    }
}
