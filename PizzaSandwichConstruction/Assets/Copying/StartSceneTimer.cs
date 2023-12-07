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

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the spoon.
        if (collision.gameObject.CompareTag("SpoonTeleport"))
        {
            // Start the timer when the spoon collides with the cube.
            StartResetTimer();
        }
    }

    private void StartResetTimer()
    {
        // Start the timer.
        timer = countdownTime;
        isTimerRunning = true;
    }

    private void ResetScene()
    {
        // Reload the current scene to reset it.
        
        //var dontDestroyOnLoadGameObjects = dontDestoyOnLoadScene.GetRootGameObjects();
        //GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        //foreach (object go in allObjects)
        // {
        //    Destroy(gameObject);
        //}
        SceneManager.LoadScene("Scene_1");
        
    }
}

