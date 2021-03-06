﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    public class GameController : MonoBehaviour
    {
        public MoveObject objectThatMoves;

        private Command buttonW;
        private Command buttonA;
        private Command buttonS;
        private Command buttonD;
        private Command buttonSpace;


        void Start()
        {
            //Bind the keys to default commands
            buttonW = new MoveUpCommand(objectThatMoves);
            buttonA = new MoveLeftCommand(objectThatMoves);
            buttonS = new MoveDownCommand(objectThatMoves);
            buttonD = new MoveRightCommand(objectThatMoves);
            buttonSpace = new JumpCommand(objectThatMoves);

        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                ExecuteNewCommand(buttonW);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                ExecuteNewCommand(buttonA);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                ExecuteNewCommand(buttonS);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                ExecuteNewCommand(buttonD);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ExecuteNewCommand(buttonSpace);
            }
        }

        private void ExecuteNewCommand(Command commandButton)
        {
            commandButton.Execute();
        }
    }

    
}
