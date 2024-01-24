using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collisionscript : MonoBehaviour
{
    int score;
    public Text scoreText;
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            score++;
            scoreText.text = "Score : " + score.ToString();
        }
    }
}
