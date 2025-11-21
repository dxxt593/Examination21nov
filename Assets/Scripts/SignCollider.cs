using UnityEngine;

public class SignCollider : MonoBehaviour
{
    public GameObject signText;
    private bool colliding = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!colliding)
        {
            signText.gameObject.SetActive(false);
        }
        else
        {
            signText.gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Player":
                colliding = true;
                break;
        }
    }

    void OnTriggerLeave2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Player":
                colliding = false;
                break;
        }
    }
}
