using UnityEngine;

public class Enemy : Character
{
    private void Update()
    {
        Move();
    }

    public override void Move() 
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 3f, 0.5f, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            ScoreManager.Instance.AddScore(100); 
            Die();
        }
    }
}
