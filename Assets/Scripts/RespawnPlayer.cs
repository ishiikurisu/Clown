using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public Transform player;
    public Transform respawn;

    void Respawn()
    {
        // IDEA give lives to player so they can lose life here
        player.position = respawn.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        Invoke("Respawn", 1f);
    }
}
