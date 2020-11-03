using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public Rigidbody rg, rgBall;
    public Transform[] positions;
    public float player2Speed;
    public GameObject player2, ball;
    private Animator anim;
    private int actualPos = 0;
    private int nextPos = 1;
    private Transform hitter;
    // Start is called before the first frame update
    void Start()
    {
        rgBall = ball.GetComponent<Rigidbody>();
        anim = player2.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer2();
    }

    void movePlayer2()
    {
        rg.MovePosition(Vector3.MoveTowards(rg.position, positions[nextPos].position, player2Speed * Time.deltaTime));
        if(actualPos==0)
        {
            anim.SetBool("right", false);
            anim.SetBool("left", true);
        }
        else
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
        }
        if((Vector3.Distance(rg.position,positions[nextPos].position) <= 0))
        {
            actualPos = nextPos;
            nextPos++;
            
            if (nextPos > positions.Length - 1)
            {
                nextPos = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            hitter = collision.transform;
            Vector3 distance = hitter.position - transform.position;
            rgBall.AddForce(-distance * 100);

        }
    }
}
