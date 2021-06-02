using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana11
{
    [Serializable]
    public class ItemData
    {
        public string name;
        public int damage = 10;
        public int lvlRequired = 2;
        public Sprite image;
    }
}
