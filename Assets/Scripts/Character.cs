using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected float speed = 5f; 

    public abstract void Move();

    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}
