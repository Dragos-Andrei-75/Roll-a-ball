using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text winText;
    private int numberOfPickUps;

    void Start()
    {
        numberOfPickUps = GameObject.FindGameObjectsWithTag("PickUp").Length;
        controller = gameObject.GetComponent<PlayerController>();
        scoreText = GameObject.Find("Score Text").GetComponent<Text>();
        winText = GameObject.Find("Win Text").GetComponent<Text>();
        winText.enabled = false;
    }

    void Update()
    {
        Score();
        LevelComplete();
    }

    void Score()
    {
        scoreText.text = "Score: " + controller.score.ToString();
    }

    void LevelComplete()
    {
        if(controller.score == numberOfPickUps)
        {
            winText.enabled = true;
        }
    }
}
