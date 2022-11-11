using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    private Health healthPlayer;
    public enum GameState
    {
        Playing,
        GameOver
    }
    public GameState gameState = GameState.Playing;

    public Text healthText;
    public Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindWithTag("player");
        }
        healthPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "" + healthPlayer.healthPoints;
        if (healthPlayer.isAlive)
        {
            pointsText.text = "" + player.GetComponent<Points>().points;
        }

        switch (gameState)
        {
            case GameState.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = GameState.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }
                break;
        }
    }
}
