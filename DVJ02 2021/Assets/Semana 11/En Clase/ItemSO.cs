using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Semana11
{
    [CreateAssetMenu(fileName = "Item", menuName = "Clase/Item" + "")]
    public class ItemSO : ScriptableObject
    {
        public ItemData itemData;
        public Sprite itemIcon;
        public GameObject modelo3D;
    }
}
