﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
     class Castle : CharacteristicBuilding, IBuilding
    {
        public Castle(int defence)
        {
            _defence = defence;
        }
        public void Collabaration()
        {
            Console.WriteLine("Castle collabaration");
        }
    }
}
