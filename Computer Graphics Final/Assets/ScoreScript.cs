using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;
    public Material wallMaterial;
    public Material floorMaterial;
    public GameObject waveEffect;

    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        wallMaterial.SetFloat("_LineColorChangeSpeed", 0.5f); // Initial speed
        wallMaterial.SetFloat("_FresnelColorChangeSpeed", 0.5f); // Initial speed
        floorMaterial.SetFloat("_ScrollX", 0.2f); // Initial scroll speed
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int increase = Random.Range(0, 101); // Generate a random score between 0 and 100
            score += increase;
            scoreText.text = "Score: " + score.ToString();

            wallMaterial.SetFloat("_LineColorChangeSpeed", 0.5f + (score / 1000f)); // Increase speed based on score
            wallMaterial.SetFloat("_FresnelColorChangeSpeed", 0.5f + (score / 1000f)); // Increase speed based on score
            floorMaterial.SetFloat("_ScrollX", 0.2f + (score / 1000f)); // Increase scroll speed based on score
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            score = 0;
            scoreText.text = "Score: " + score.ToString();

            wallMaterial.SetFloat("_LineColorChangeSpeed", 0.5f); // Reset speed
            wallMaterial.SetFloat("_FresnelColorChangeSpeed", 0.5f); // Reset speed
            floorMaterial.SetFloat("_ScrollX", 0.2f); // Reset scroll speed
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            waveEffect.SetActive(!waveEffect.activeSelf);
        }
    }
}
