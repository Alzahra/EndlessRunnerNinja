using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public int damage = 1;
    public float speed;

    public GameObject obstacleEffect;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(obstacleEffect, transform.position, Quaternion.identity);
            collision.GetComponent<PlayerController>().health -= damage;
            collision.GetComponent<PlayerController>().WriteLife(collision.GetComponent<PlayerController>().health);
            
            Destroy(gameObject);
        }
    }

    
}
