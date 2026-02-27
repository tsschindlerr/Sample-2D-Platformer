using UnityEngine;

public class TogglePlatform : MonoBehaviour
{
    public Sprite onSprite;
    public Sprite offSprite;
    public float onDuration = 3f;
    public float offDuration = 2f;
    public bool startOn = true;

    private SpriteRenderer sr;
    private Collider2D col;
    private bool isOn;
    private float timer;
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }
    void Start()
    {
        isOn = startOn;
        col.enabled = isOn;
        sr.sprite = isOn ? onSprite : offSprite;
        timer = isOn ? onDuration : offDuration;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            isOn = !isOn;
            col.enabled = isOn;
            sr.sprite = isOn ? onSprite : offSprite;
            timer = isOn ? onDuration : offDuration;
        }
    }
}