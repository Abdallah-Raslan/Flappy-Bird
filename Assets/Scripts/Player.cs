using UnityEngine;


public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] sprites;
    int spriteIndex;

    private Vector3 direction;
    [SerializeField] float gravity = -9.8f;
    [SerializeField] float strength = 5f;
    [SerializeField] float tiltSmoothnessUp = 20f;
    [SerializeField] float tiltSmoothnessDown = 5f;
    float targetAngle = 0;
    float tiltSmoothness = 0;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void OnEnable()
    {

        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
        direction.y = 0;

    }

    private void Update()
    {

        // Jumping input

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        // Automatically fall
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        // Rotate the bird based on its vertical movement

        if (direction.y > 0) // Bird is going up
        {
            targetAngle = 60f;
            tiltSmoothness = tiltSmoothnessUp;
        }
        else if (direction.y < 0) // Bird is falling down
        {
            targetAngle = -90f;
            tiltSmoothness = tiltSmoothnessDown;
        }

        // Smoothly interpolate the rotation angle
        float angle = Mathf.LerpAngle(transform.eulerAngles.z, targetAngle, tiltSmoothness * Time.deltaTime);

        // Apply the rotation
        transform.eulerAngles = new Vector3(0, 0, angle);

    }

    // Animation cycle
    void AnimateSprite()
    {
        spriteIndex++;

        if(spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
        } 
        
        else if (other.gameObject.tag == "Scoring")

        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }



}
