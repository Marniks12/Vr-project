using UnityEngine;

public class LungAnimatorTrigger : MonoBehaviour
{
    public Animator lungAnimator;

    void Start()
    {
        // Start de overgang na 2 seconden
        Invoke("TriggerOpen", 2f);
    }

    void TriggerOpen()
    {
        lungAnimator.SetTrigger("OpenAirways");
    }
}
