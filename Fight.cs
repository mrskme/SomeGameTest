using System;
using System.Collections.Generic;
using System.Text;

namespace SomeGameTest
{
    class Fight
    {
        private Player _player;
        private Enemy[] _enemy;

        public Fight(Player player, Enemy[] enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void PlayerVsEnemyFight()
        {
            while (_player.Health > 0 || _enemy[1].Health > 0)
            {
                _player._isTakingDamage = true;
            }
        }
    }
}
