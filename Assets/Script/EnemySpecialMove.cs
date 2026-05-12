using UnityEngine;

public class EnemySpecialMove : MonoBehaviour
{
    public float Speed = 2.0f;
    public float verticalSpeed = 3.0f;
    public float yRange = 3.0f;

    private int directionY = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //XŽ²‚Ö‚ÌˆÚ“®
        float moveX = -Speed * Time.deltaTime;

        //YŽ²‚Ö‚ÌˆÚ“®
        float moveY = directionY * verticalSpeed * Time.deltaTime;

        //ˆÚ“®ˆ—
        transform.Translate(new Vector3(moveX, moveY, 0));

        //ã‚É‚Ô‚Â‚©‚Á‚½‚ç’µ‚Ë•Ô‚é
        if(transform.position.y >= yRange)
        {
            directionY = -1;
        }
        else if (transform.position.y <= -yRange)
        {
            directionY = 1;
        }

        //‰æ–ÊŠO‚ÉŒ¾‚Á‚½‚ç
        if (transform.position.x <= -12f)
        {

            Destroy(gameObject);
        }
    }
}
