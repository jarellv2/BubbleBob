using UnityEngine;

public class BubbleFactory : MonoBehaviour
{
    public static BubbleFactory Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public GameObject CreateBubble(Vector3 spawnPosition)
    {
        GameObject bubble = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        bubble.transform.position = spawnPosition;
        bubble.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        bubble.GetComponent<Renderer>().material.color = Color.green;

        Rigidbody rb = bubble.AddComponent<Rigidbody>();
        rb.useGravity = false;
        rb.velocity = Vector3.forward * 10f;

        Destroy(bubble, 2f);
        return bubble;
    }
}
