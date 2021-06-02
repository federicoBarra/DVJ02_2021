using UnityEngine;

namespace DVJ02.Semana11
{
    [CreateAssetMenu(fileName = "ScriptableObjectExample", menuName = "Clase DVJ02/ScriptableObjectExample" + "", order = 1)]
	public class ScriptableObjectExample : ScriptableObject
	{
	    //https://docs.unity3d.com/Manual/class-ScriptableObject.html
	    public string nombre;
	    public float fuerza = 10;
	    public Sprite portrait;
	    public GameObject prefabQueInstancia;

	    public string GetBasicInfo()
	    {
	        return nombre + " | " + fuerza;
	    }
	}
}

