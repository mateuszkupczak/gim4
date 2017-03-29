using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;

    int score;

    // Use this for initialization
    void Start()
    {
        RefreshCountText();
    }
    
    // When the player collides with any known target (tag)
    void OnTriggerEnter(Collider other)
    {
        var encounteredObject = other.gameObject;
        if (encounteredObject.CompareTag("Target") && encounteredObject.GetComponent<ConstantForce>().torque == new Vector3(20, 0, 0))
        {
            encounteredObject.GetComponent<ConstantForce>().torque = new Vector3(40, 0, 0);
            HandleObjectCollision(other.gameObject, 1);
        }
    }

    // Update the score based on the main criteria of how much we should add
    private void HandleObjectCollision(GameObject currentGameObject, short scoreToAdd)
    {
        score += scoreToAdd;
        RefreshCountText();
    }

    // Reproduce the score text.
    private void RefreshCountText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
