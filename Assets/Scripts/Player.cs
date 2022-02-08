﻿using System;
using UnityEngine;

public class Player : Character
{


    protected void Start()
    {
        //Builds its essential components from the Character Class
        base.Start();

        //builds its own components
       
    }

    protected void Update()
    {
        //Here the keyboard/mobile inputs are written and redirected to it's proper functions
        //depending on the implementation, add as many key as needed

        if (!alive) return;

#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBPLAYER
        
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

#else

        horizontal = mobileJoystick.Horizontal;
        vertical = mobileJoystick.Vertical;

#endif

        
        /*
        if (Input.GetKeyDown(KeyCode.X))
            attemptToInteract();

        if (Input.GetKeyDown(KeyCode.Escape))
            levelManager.PauseGame();

        if (Input.GetKeyDown(KeyCode.H))
            levelManager.OnOffInstructions();
        */
    }

    protected override void PhysicalMove()
    {
        Vector2 position = myRigidBody.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        myRigidBody.MovePosition(position);
    }

    /*
    public void attemptToInteract()
    {
        RaycastHit2D hit = Physics2D.Raycast(myRigidBody.position + Vector2.up * 0.3f, lookDirection, 1.5f, LayerMask.GetMask("NPC"));
        if (hit.collider != null)
        {
            NonPlayerCharacter nPCharacter = hit.collider.GetComponent<NonPlayerCharacter>();
            if (nPCharacter != null)
                nPCharacter.Interact();
        }
    }
    */
    public override void OnCollisionEvent(Collision2D collision)
    {
        throw new NotImplementedException();
    }
}
