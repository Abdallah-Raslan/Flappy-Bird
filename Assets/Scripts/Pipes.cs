using UnityEngine;

public class Pipes : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    float leftEdge;


    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;


        if (transform.position.x < leftEdge )
        {
            Destroy(gameObject);
        }

    }

}
