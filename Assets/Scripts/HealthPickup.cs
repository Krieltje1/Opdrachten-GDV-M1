using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Potion"))
        {
            if (health < maxHealth)
            {
                int healAmount = 10;

                if (health + healAmount > maxHealth)
                {
                    healAmount = maxHealth - health;
                }

                Destroy(other.gameObject);
                health += healAmount;
                Debug.Log("You gained: " + healAmount + " health");
            }
            else
            {
                Debug.Log("You already have max health");
            }

        }
        

        
    }
}
