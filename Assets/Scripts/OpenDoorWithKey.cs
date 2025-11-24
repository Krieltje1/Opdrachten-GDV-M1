using NUnit.Framework;
using UnityEngine;

public class OpenDoorWithKey : MonoBehaviour
{

    bool hasKey = false;
    bool nearKey = false;
    bool nearDoor = false;
    public GameObject Door;
    public GameObject Key;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (nearKey)
            {
                hasKey = true;
                Debug.Log("You picked up the key!");
                Destroy(Key);
            }

            if (nearDoor && hasKey)
            {
                Destroy(Door);
                hasKey = false;
                Debug.Log("You Opened the door! Well done!");
            }

            if (nearDoor && !hasKey)
            {
                Debug.Log("Please get the key before opening this door.");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key")) nearKey = true;
        if (other.CompareTag("Door")) nearDoor = true;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Key")) nearKey = false;
        if (other.CompareTag("Door")) nearDoor = false;
    }
}
