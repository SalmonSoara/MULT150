using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour7Part1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int enemies = 10;
        Debug.Log("amount of enemies: " + enemies);

        float health = 99.5f;
        double coords = 0150.98579458785;
        Debug.Log("health is " + health);
        Debug.Log("coords are " + coords);

        bool playerIsAlive = true;
        bool gameOver = false;
        Debug.Log(playerIsAlive);
        Debug.Log(gameOver);

        char input = 'b';
        Debug.Log("input is " + input);

        string saying = "Then I took an arrow in the knee.";
        Debug.Log(saying);
        /*string someWords = "Then I took an";
        string moreWords = "arrow in the knee";
        string result = someWords + moreWords;
        Debug.Log(result);*/

        /*//Debug.Log(1 + 1);
        int a = 1;
        int b = 1;
        //Debug(a + b);
        int result = a + b;
        Debug.Log(result);*/

        /*int a = 2;
        int b = 1;
        int result = a - b;
        Debug.Log(result);*/

        /*int a = 2;
        int b = 3;
        int result = a * b;
        Debug.Log(result);*/

        int a = 6;
         int b = 3;
        int result = a/b;
        Debug.Log(result);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
