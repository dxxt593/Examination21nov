using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;
    public GameObject LoseUI;    
    public GameObject WinUI;

    private bool damageable = true;
    private float damageTimer = 2;
    private float winTimer = 1.5f;
    public int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
            LoseUI.gameObject.SetActive(true);
        }

        if (score == 3)
        {
            winTimer -= Time.deltaTime;
            if (winTimer <= 0)
            {
                gameObject.SetActive(false);
                WinUI.gameObject.SetActive(true);
            }
        }

        if (!damageable)
        {
            damageTimer -= Time.deltaTime;
        }

        if (damageTimer <= 0)
        {
            damageable = true;
            damageTimer = 2;
        }
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
                if (damageable)
                {
                    Debug.Log("ouch :(");
                    health--;
                    damageable = false;
                }
                break;
        }
    }
}
