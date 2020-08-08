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
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rigidBody.AddForce(0, 0, playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rigidBody.AddForce(0, 0, -playerSpeed * Time.deltaTime);
        }

        // jumping
        bool grounded = Physics.Raycast(transform.position, Vector3.down, raycastCheck);
        if (Input.GetButton("Jump")) {
            Debug.Log("space bar was pressed");
            if (grounded) {
                rigidBody.AddForce(0, playerJumpSpeed, 0, ForceMode.Force);
            }
        }
    }
}
