using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    //public Transform spawnPoint;
    public GameObject player;
    private bool isGameOver = false;

    public GoalScript blue, green, red, orange;

   // private FirstPersonController FPSController;

    /*void Start()
    {
        Physics.autoSyncTransforms = true;
   
        FPSController = player.GetComponent<FirstPersonController>();

        FPSController.enabled = true;

    }*/

    /*private void StartGame()
    {
        isGameOver = false;
        //GetComponent<MeshRenderer>(Blue_Ball).enabled = true;
        //GetComponent<MeshRenderer>(Green_Goal).enabled = true; //not working
        PositionPlayer();
        FPSController.enabled = true;
    }*/

    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }

    /*public void PositionPlayer()
    {
        player.transform.position = spawnPoint.position;
        player.transform.rotation = spawnPoint.rotation;
    }*/

    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");

            /*FPSController.enabled = false;
            Rect startButton = new Rect(Screen.width / 2 - 120, Screen.height / 2, 240, 30);
            GUI.Label(startButton, "Press Enter to Play Again");
            if (Input.GetKeyDown(KeyCode.Return))
            {
                StartGame();
            }*/
        }
    }
}