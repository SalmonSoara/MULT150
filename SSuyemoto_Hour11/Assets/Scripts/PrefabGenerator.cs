using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int x = 0; x < 10; ++x)
        {
             Instantiate(prefab, new Vector3(x * 3, 1.4f, -6), Quaternion.identity);
            
        }
    }

    /*void Start()
    {
        for (int count = 1; count <= 10; count += 1)
        {
            Instantiate(prefab);
        }
        
    }*/

    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}