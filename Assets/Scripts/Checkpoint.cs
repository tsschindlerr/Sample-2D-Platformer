using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public static Vector2 savedPosition = Vector2.zero;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            savedPosition = collision.transform.position;
        }
    }
}