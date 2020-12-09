using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void ExitLevel()
    {
        SceneManager.LoadScene("Start");
    }






}
