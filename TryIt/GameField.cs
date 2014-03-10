using System;
using System.Collections.Generic;
using System.Text;

namespace TryIt
{
    class GameField
    {
        public const int FieldH = 200;
        public const int FieldW = 200;
        private readonly bool[,] _stars;

        public GameField(short seed)
        {
            _stars = new bool[FieldH, FieldW];
            //_stars[50, 50] = true;
            var rdm = new Random();
            for (int i = 0; i < FieldH; i++)
                for (int j = 0; j < FieldW; j++)
                {
                    if (rdm.Next(0, 128) < seed)
                        _stars[i, j] = true;
                }
        }

        public bool[,] Stars
        {
            get { return _stars; }
        }
    }
}
