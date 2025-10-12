using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    // Start is called before the first frame update

    //notes from video
    void Start()
    {
        int health = 100;

        if (health == 20) //== equal, != not equal
        {
            Debug.Log("player has been unalived!");
        }
        else if (health < 30) //"otherwise"
        {
            Debug.Log("DANGER! Low health");
        }
        else if (health == 100) //"otherwise"
        {
            Debug.Log("player is chilling");
        }
        else //"in all other cases"
        {
            Debug.Log("player is alive");
        }

        //get sum of all numbers 1 to 10
        int sum = 0;
        int count = 1;
        while (count <= 10)
        {
            Debug.Log("sum:" + sum + " count:" + count);
            sum = sum + count; //sum += count
            count++;
        }
        Debug.Log("final sum: " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
