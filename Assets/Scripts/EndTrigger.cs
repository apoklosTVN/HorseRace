using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] public GameManager gameManagerScript;

    void OnTriggerEnter(Collider collision) 
    {
        if (collider.CompareTag("Player"))
        {
            gameManagerScript.CompleteLevel();
        }
    }
}
