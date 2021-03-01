using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    public class MoveDownCommand : Command
    {
        private MoveObject moveObject;

        public MoveDownCommand(MoveObject moveObject)
        {
            this.moveObject = moveObject;
        }

        public override void Execute()
        {
            moveObject.MoveDown();
        }

        public override void Undo()
        {
            moveObject.MoveUp();
        }
    }
}
