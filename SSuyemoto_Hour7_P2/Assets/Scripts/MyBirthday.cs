using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //"common to shorten counts to single letters" d = day; bd = bday
       
        int bd = 6;
        {
            for (int d = 1; d <= 31; d++)
            { 
                if(d != bd)
                {
                Debug.Log(d);
                }

                else if(d == bd)
                {
                 Debug.Log("It's my Birthday!");
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
