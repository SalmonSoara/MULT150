using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //first attempt
        /*
        int count = 22;

        while (count <= 100)
            {
            Debug.Log(count);
            count += 2;
            }
        */

        //attempt by 1st video example
        for (int count = 22; count <= 100; count += 2 )
        {
            Debug.Log(count);
        }
     
        //"could also a loop and an if statement" divisible by two..? long list of even numbers ? not sure

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
