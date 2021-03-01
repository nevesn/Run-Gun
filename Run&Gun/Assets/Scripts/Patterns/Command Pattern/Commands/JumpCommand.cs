using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    public class JumpCommand : Command
    {
        private MoveObject moveObject;

        public JumpCommand(MoveObject moveObject)
        {
            this.moveObject = moveObject;
        }

        public override void Execute()
        {
            moveObject.Jump();
        }

        public override void Undo() 
        {
            moveObject.Jump();
        }
    }
}
