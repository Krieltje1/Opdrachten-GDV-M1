using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{

    public string currentWeapon = "Sword";
    int damage;
    float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipWeapon("Sword");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EquipWeapon("Bow");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EquipWeapon("Staff");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            EquipWeapon("Dagger");
        }
    }

    void EquipWeapon(string weaponName)
    {
        currentWeapon = weaponName;
        ChangeWeapon();
        Debug.Log("Current Weapon: " + weaponName);
        Debug.Log("Damage: " + damage + ", Speed: " + speed);
    }
    
    void ChangeWeapon()
    {
        switch (currentWeapon)
        {
            case "Sword":
                damage = 25;
                speed = 1;
                break;
            case "Bow":
                damage = 20;
                speed = 1.5f;
                break;
            case "Staff":
                damage = 35;
                speed = 0.7f;
                break;
            case "Dagger":
                damage = 20;
                speed = 2.0f;
                break;
            default:
                damage = 10;
                speed = 1.0f;
                break;
        }
         
        
    }
}
