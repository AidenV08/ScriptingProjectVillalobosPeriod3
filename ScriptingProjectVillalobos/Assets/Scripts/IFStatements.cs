using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotlimitTemperature = 70.0f;
    float coldlimitTemperautre = 40.0f


    void Update()
    {
        if (Input.GetKeyDown(Keycode))
            TemeratureTest();

        coffeeTemperature -= Time.deltaTime * 5f;

    }


    void TemperatureTest()
    {
        // If the coffee's tempurature is greater than the hottest drinking temperature...
        if (coffeeTemperatureTemperature > hotlimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperatureTemperature < coldlimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold. ");
        }
        // If it is neithher of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}

    
   