using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene: MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
}
