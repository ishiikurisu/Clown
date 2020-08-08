using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float playerSpeed = 50;

    void Start()
    {

    }

    void FixedUpdate()
    {
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
        // TODO implement jump
    }
}
