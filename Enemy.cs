using System;
using System.Collections.Generic;
using System.Text;

namespace SomeGameTest
{
    class Enemy
    {
        private int _health = 10;

        public int Health
        {
            get
            {
                return _health;
            }
        }

        public Enemy(int health)
        {
            _health = health;

        }

    }
}
