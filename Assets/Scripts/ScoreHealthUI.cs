using UnityEngine;
using TMPro;

public class ScoreHealthUI : MonoBehaviour
{
    public GameObject player;
    public TMP_Text text;
    private Player playerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerScript = player.GetComponent<Player>();
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Health: {playerScript.health}\nScore: {playerScript.score}";
    }
}
