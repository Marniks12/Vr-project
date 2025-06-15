using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class ZoomLungLoader : MonoBehaviour
{
    public string sceneToLoad = "ZoomLungScene";

    // Wordt automatisch aangeroepen wanneer geselecteerd
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log(" Long geselecteerd, laden van scene: " + sceneToLoad);
        SceneManager.LoadScene(sceneToLoad);
    }
}
