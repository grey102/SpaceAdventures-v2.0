using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
    public Rigidbody mt;
    //private float speed = -1f;

    private void FixedUpdate()
    {
        //mt.velocity = transform.position * speed;
        mt.MovePosition(transform.position + new Vector3(0f, 0.0f, -2.0f) * Time.fixedDeltaTime);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
