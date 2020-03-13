
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
 
    
    public void playGame() {
        SceneManager.LoadScene(1);
       
    }
    public void replayGame()
    {
        SceneManager.LoadScene(1);
       
    }
    public void quitGame()
    {
        Application.Quit();
       
    }
    public void loadMenu()
    {
        SceneManager.LoadScene(0);
       
    }
    public void optionsMenu()
    {
        SceneManager.LoadScene(3);
        
    }
    public void soundMenu()
    {
        SceneManager.LoadScene(4);
       
    }

   
   

}
