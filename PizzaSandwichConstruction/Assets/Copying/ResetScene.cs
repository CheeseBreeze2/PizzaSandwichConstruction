using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneResetWithTimer : MonoBehaviour
{
    public float countdownTime = 10f; // Set the countdown time in seconds in the Inspector.

    private float timer;
    private bool isTimerRunning;

    private void Update()
    {
        // Update the timer if it's running.
        if (isTimerRunning)
        {
            timer -= Time.deltaTime;

            // Check if the timer has reached zero.
            if (timer <= 0f)
            {
                // Reset the scene when the timer reaches zero.
                ResetScene();
            }
        }
    }

    public void StartResetTimer()
    {
        // Start the timer when called.
        timer = countdownTime;
        isTimerRunning = true;
    }

    private void ResetScene()
    {
        // Reload the current scene to reset it.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
