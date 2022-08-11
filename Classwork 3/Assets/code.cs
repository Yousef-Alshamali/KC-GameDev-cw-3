using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    string heroName = "Ahmed";
    float heroPower = 15.4f;

    string villainName = "Hashem";
    float villainPower = 12.7f;

    float playerSpeed = 5.4f;

    // Start is called before the first frame update
    void Start()
    {
        print("The hero's name is " + heroName + " and his power is " + heroPower);
        print("The villain's name is " + villainName + " and his power is " + villainPower);
        if (heroPower > villainPower)
        {
            print("The hero's power is higher than the villain's power");
        }
        else if (villainPower > heroPower)
        {
            print("The villain's power is higher than the hero's power");
        }
        else
        {
            print("The hero's power is the same as the villain's power");
        }

        SetSpeed(2.5f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSpeed(float speed)
    {
        if (playerSpeed > speed)
        {
            print("old speed is higher");
        }
        else if (playerSpeed < speed)
        {
            print("new speed is higher");
        }
        else
        {
            print("both speeds are the same");
        }

        print("The old speed is " + playerSpeed);
        playerSpeed = speed;
        print("The new speed is " + playerSpeed);
    }
}
