using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchControl : MonoBehaviour
{
    public void Update()
    {    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "Menu")
            {
                Application.Quit();

            }
            if (SceneManager.GetActiveScene().name == "World")
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
