using UnityEngine;

public class Parallax : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [SerializeField] float animationSpeed = 1f;


    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }

}
