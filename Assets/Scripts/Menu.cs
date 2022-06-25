using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text ListText;

    public void startGame()
    {
        SceneManager.LoadScene("World");
    }
    public void openRecords()
    {
        ListText.text = "Records";
        ListText.fontSize = 24;
    }
    public void openCredits()
    {
        ListText.text = "Made by Maxim Khitrin for Eudokia Games";
        ListText.fontSize = 12;
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
