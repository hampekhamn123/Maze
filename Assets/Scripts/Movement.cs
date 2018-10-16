using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rBody;
    private bool rightMovement = false;
    private bool leftMovement = false;
    private bool upMovement = false;
    private bool downMovement = false;

    void Start()
    {

    }

    void Update()
    {
        MovementKeys();
        Scenerestart();
    }

    void FixedUpdate()
    {
        PlayerMovement();
    }

    void MovementKeys()
    {
        if (Input.GetKey(KeyCode.A))
        {
            leftMovement = true;
        }
        else
        {
            leftMovement = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            downMovement = true;
        }
        else
        {
            downMovement = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rightMovement = true;
        }
        else
        {
            rightMovement = false;
        }

        if (Input.GetKey(KeyCode.W))
        {
            upMovement = true;
        }
        else
        {
            upMovement = false;
        }
    }

    void PlayerMovement()
    {
        //addforce är efter skärmen
        //addrelativeForce är för den själv
        //AddTorque roterar
        //moveposition är rör direkt
        //moverotation är rotera direkt
        //velocity är hastighet
        //angularvelocity är hastighet runt sin egen axel 
        if (rightMovement == true)
        {
            rBody.AddForce(new Vector2(10f, 0));
        }

        if (leftMovement == true)
        {
            rBody.AddForce(new Vector2(-10f, 0));
        }

        if (upMovement == true)
        {
            rBody.AddForce(new Vector2(0, 10f));
        }

        if (downMovement == true)
        {
            rBody.AddForce(new Vector2(0, -10f));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Maze");
    }

    void Scenerestart()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Maze");
        }
    }
}
