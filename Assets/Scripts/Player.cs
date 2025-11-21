using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour
{
    private AudioSource sfx;
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        sfx = GetComponent<AudioSource>();
        sfx.Play();
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
                other.gameObject.SetActive(false);
                break;
        }
    }
}
