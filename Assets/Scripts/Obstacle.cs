using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float rotateSpeed;

    void FixedUpdate()
    {
        transform.Rotate(0,0,rotateSpeed);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            GameManager.gm.GameOVer();
        }
        else if (col.gameObject.tag == "Ground")
        {
            GameManager.gm.IncrementScore();

            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}