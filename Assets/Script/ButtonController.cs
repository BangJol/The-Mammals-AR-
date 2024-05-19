using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button yourButton; // Assign this in the inspector

    void Start()
    {
        // Attach the click event listener
        yourButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Button Clicked!");

        // Play the button click sound using AudioManager
        AudioManager.Instance.PlayButtonSFX();
    }
}