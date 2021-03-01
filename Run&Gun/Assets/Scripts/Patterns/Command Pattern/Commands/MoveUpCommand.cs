using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    public class MoveUpCommand : Command
    {
        private MoveObject moveObject;

        public MoveUpCommand(MoveObject moveObject)
        {
            this.moveObject = moveObject;
        }

        public override void Execute()
        {
            moveObject.MoveUp();
        }

        public override void Undo() 
        {
            moveObject.MoveDown();
        }
    }
}
