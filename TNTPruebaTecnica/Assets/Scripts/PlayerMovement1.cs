using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement1 : MonoBehaviour
{
    public float VelMove = 5.0f;
    public float VelRot = 200.0f;
    private Animator anim;
    public GameObject player, JoystickMovePlayer, JumpBTN;
    public float x, y;

    public Joystick joystick;

    public bool kick;

    public BallMovement ballMove;     
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = player.GetComponent<Animator>();

        kick = false;
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            JoystickMovePlayer.SetActive(true);
            JumpBTN.SetActive(true);
        }
        else
        {
            JoystickMovePlayer.SetActive(false);
            JumpBTN.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            x = joystick.Horizontal;
            y = joystick.Vertical;
        }
        else
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");
        }


        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (Input.GetKeyDown(KeyCode.Space) || activateKick() )
        {
            Debug.Log("Patea");
            anim.SetBool("Kick", true);
            ballMove.touchKick();
        }
        else
        {
            anim.SetBool("Kick", false);
        }
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * VelRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * VelMove);
    }

    public bool activateKick()
    {
        if(kick)
        {
            kick = false;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void kickActive()
    {
        kick = true;      
    }
}
