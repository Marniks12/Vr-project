using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStarter : MonoBehaviour
{
    public string sceneToLoad = "Create-With-VR-Starter-Scene"; // Vervang met jouw simulator scene naam

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
