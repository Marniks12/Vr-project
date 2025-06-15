using UnityEngine;

public class StartTrainingUI : MonoBehaviour
{
    public GameObject uiPanel;

    public void HidePanel()
    {
        uiPanel.SetActive(false);
        Time.timeScale = 1f; // Zorgt dat de simulator verdergaat
    }

    private void Start()
    {
        Time.timeScale = 0f; // Pauzeer de simulator tot speler klikt
    }
}
