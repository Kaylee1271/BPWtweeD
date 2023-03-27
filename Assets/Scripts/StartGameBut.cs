using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameBut : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
