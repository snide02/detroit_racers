using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISystems : MonoBehaviour
{
    public scoremanager SM;


    public void Start()
    {
        SM = FindObjectOfType<scoremanager>();
    }

    public void toMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    //take you to the game when you press start

    public void toGame()
    {
        SceneManager.LoadScene(1);
    }
   
    public void toQuit()
    {
        Application.Quit();
    }
    

    public IEnumerator restartgame()//does not currently restart the game
    {
        SM.isincreasing = false; // stops your score when you die
        yield return new WaitForSeconds(1f); // this makes the game delay 

        
        
                                    // THIS IS WHERE THE RESART ANIMATION HAS TO GO 


        SM.scorecount = 0; // this resets your score
        SM.isincreasing = true; // this makes it so the score will count again has to be the last thing in the restart process

    }
}