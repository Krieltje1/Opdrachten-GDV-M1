using System.Data.Common;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public GameObject ColorPlatform;
    bool onPlatform;
    Material material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = ColorPlatform.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (onPlatform && Input.GetKeyDown(KeyCode.R))
        {
            material.color = Color.red;
            Debug.Log("Current color: Red");
        }

        if (onPlatform && Input.GetKeyDown(KeyCode.G))
        {
            material.color = Color.green;
            Debug.Log("Current color: Green");
        }

        if (onPlatform && Input.GetKeyDown(KeyCode.B))
        {
            material.color = Color.blue;
            Debug.Log("Current color: Blue");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            onPlatform = true;
            Debug.Log("Player is standing on platform, press R, G or B to change color!");  
        } 
    }
}
