using UnityEngine;

public class SpeedPad : MonoBehaviour
{
    public float upForce;
    public float forwardForce;

    private Player player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player = collision.gameObject.GetComponent<Player>();
            player.speedBoost = true;
            Rigidbody2D rb = collision.transform.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(forwardForce, upForce), ForceMode2D.Impulse);
            Invoke("DisableSpeedBoost", 0.3f);
        }
    }

    void DisableSpeedBoost()
    {
        player.speedBoost = false;
    }
}