using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class MainMenuUI : MonoBehaviour
    {
    
        public void OnClickPlay()
        {
            SceneManager.LoadScene(1);
        }
    
        public void OnClickExit()
        {
            Application.Quit();
        }
    }
}
