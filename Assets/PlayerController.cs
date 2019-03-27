using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour {

    public Animator animator;
    private Vector2 targetPos;

    public GameObject effect;

    public int health = 3;
    public float Yincrement;

    public float minHeight;
    public float maxHeight;

    public float speed;

    // For health
    public GameObject LifeText;
    // For Score
    public float distanceScore = 0.0f;
    public GameObject ScoreText;

    private void Awake()
    {
        WriteLife(health);
    }

    // Update is called once per frame
    void Update () {

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (health <= 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Up();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Down();
        }
    }

    private void LateUpdate()
    {
        distanceScore += 5 * Time.deltaTime;
        WriteScore((int)distanceScore);
    }

    public void Up()
    {

        Instantiate(effect, transform.position, Quaternion.identity);
        /*animator.SetBool("SautHaut", true);
        animator.SetBool("SautBas", false);
        animator.SetBool("PasdeMouvement", false);*/
        if (transform.position.y < 6)
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
    }

    public void Down()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        /*animator.SetBool("SautBas", true);
        animator.SetBool("SautHaut", false);
        animator.SetBool("PasdeMouvement", false);*/
        if (transform.position.y >= -6)
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
    }

    public void WriteLife(int life)
    {
        LifeText.GetComponent<TextMeshProUGUI>().text = life.ToString();
    }


    public void WriteScore(int distance)
    {
        ScoreText.GetComponent<TextMeshProUGUI>().text = distance.ToString();
    }
    
}
