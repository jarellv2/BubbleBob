using UnityEngine;

public class Player : Character
{
    private void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BubbleFactory.Instance.CreateBubble(transform.position + Vector3.forward);
        }
    }

    public override void Move() 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
    }
}
