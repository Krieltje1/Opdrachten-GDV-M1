using UnityEngine;

public class HealthStatus : MonoBehaviour
{

    public int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 80)
        {
            Debug.Log("Excellent Health!");
        }
        else if (health > 50)
        {
            Debug.Log("Good Health!");
        }
        else if (health > 20)
        {
            Debug.Log("Warning: Low Health!");
        }
        else
        {
            Debug.Log("Warning: Critical Health!");
        }
        HealthChanger();
    }

    void HealthChanger()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health -= 10;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            health += 10;
        }
    }
}
