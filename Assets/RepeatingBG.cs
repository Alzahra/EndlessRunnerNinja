using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour {

    public float speed;

    public float endX; 
    public float startX;//ou il doit se remettre
    public float endY; // il a defilé
    public float startY; //ou il doit se remettre
   

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, startY);
            transform.position = pos;
        }

	}
}
