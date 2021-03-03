using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    public class FireCommand : Command
    {
        private MoveObject moveObject;

        public FireCommand(MoveObject moveObject)
        {
            this.moveObject = moveObject;
        }

        public override void Execute()
        {
            moveObject.Fire();
        }

        public override void Undo() 
        {
            //moveObject.Fire();
            Debug.Log("Ela Desatirou, viu!(?)");
        }
    }
}
