using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public static int score = 0;
    public GameObject myText;

    public void Start()
    {
        // Text scoreText = GameObject.Find("Canvas/ScoreTMP").GetComponent<Text>();
        // Debug.Log(scoreText.text);
    }
    public void Update()
    {
    }
    public static void IncrementScore()
    {
        score++;
    } 

}
