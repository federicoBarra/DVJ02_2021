using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana11
{
    [CreateAssetMenu(fileName = "Level Config", menuName = "Clase/Level Config" + "")]
    public class LevelConfiguration : ScriptableObject
    {
        public string levelName;
        public int width = 10;
        public int height = 10;

        public int bombsCount = 10;
        public int enemiesCount = 10;
    }
}