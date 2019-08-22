using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Adventure game script is created from the game object
 * The script itself is a class called AdventureGame
 * this script object creates a textcomponent which links to the storyText object
 * and startingState which links to the state object we created
 * we get the starting state from the state template we created
 * we assign that starting state to the textComponent
*/


public class AdventureGame : MonoBehaviour { 

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;


    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update() {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }

        textComponent.text = state.GetStateStory();

    }
}

 