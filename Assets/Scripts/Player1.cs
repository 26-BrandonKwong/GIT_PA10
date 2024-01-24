using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{   
 public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
