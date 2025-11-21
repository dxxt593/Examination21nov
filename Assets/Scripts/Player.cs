using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;

    public int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        health = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        switch(other.tag) 
        {
            case "Coin":
                score++;
                GetComponent<AudioSource>().Play();
                other.gameObject.SetActive(false);
                break;
            case "Spikes":
                health--;
                break;
        }
    }
}
