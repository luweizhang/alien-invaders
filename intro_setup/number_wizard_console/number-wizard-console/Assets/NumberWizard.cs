using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int min;
    int max;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;

        Debug.Log("Welcome to Number Wizard...billy");
        Debug.Log("Pick a number!!");
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow)) { 

            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("I am a genius.");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is it higher or lower than: " + guess);
    }
}
