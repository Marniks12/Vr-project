using UnityEngine;
using UnityEngine.SceneManagement;

public class InhalatorTrainer : MonoBehaviour
{
    public Transform mouthPosition;
    private bool trainingCompleted = false;

    void Update()
    {
        if (trainingCompleted) return;

        // Check of inhalator dicht genoeg bij de mond is
        float distance = Vector3.Distance(transform.position, mouthPosition.position);
        if (distance < 0.2f)
        {
            Debug.Log("Inhalator correct gebruikt! Scene wordt geladen...");
            trainingCompleted = true;
            Invoke("LoadLungScene", 1.5f);
        }
    }

    void LoadLungScene()
    {
        SceneManager.LoadScene("LungScene");
    }
}

