using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    public class MoveObject : MonoBehaviour
    {
        private const float MOVE_STEP_DISTANCE = 1f;

        public float jumpForce = 66;
        private Rigidbody2D rb2d;

        private void Start()
        {
            rb2d = this.GetComponent<Rigidbody2D>();
        }

        public void MoveUp()
        {
            Move(Vector2.up);
        }

        public void MoveDown()
        {
            Move(Vector2.down);
        }

        public void MoveLeft()
        {
            Move(Vector2.left);
        }

        public void MoveRight()
        {
            Move(Vector2.right);
        }

        public void Jump()
        {
            //Debug.Log("Jumpei carai!");
            rb2d.AddForce(Vector2.up * jumpForce);
        }

        public void Fire()
        {
            Debug.Log("Ra ta ta ta ta!");
            //intanciar o tiro a partir do child object do player.
        }

        private void Move(Vector2 dir)
        {
            transform.Translate(dir * MOVE_STEP_DISTANCE);
        }
    }
}
