using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ttt : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Side"))
        {
            score++;
            scoreText.text = "score : " + score.ToString();
            Destroy(collision.gameObject);
        }
    }
}