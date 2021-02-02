using System;
using System.Collections.Generic;
using System.Text;

namespace SomeGameTest
{
    class Player
    {
        private int _maxHealth = 100;
        private int _health = 20;
        public bool _isTakingDamage;
        private Fight Fight;
        public int Health
        {
            get => _health;
            set
            {
                if (_isTakingDamage)
                {
                    _health -= enemyDamage;
                    _isTakingDamage = false;
                }

                if (value <= 0) _health = 0;
                else if (value >= 100) _health = 100;
                else _health = value;
            }
        }

        private int enemyDamage = 20;


        public void writeHealth()
        {
            Console.WriteLine();
        }
    }
}
