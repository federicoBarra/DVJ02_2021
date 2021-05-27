using UnityEngine;

namespace DVJ02.Semana10
{
	public class UILoadNextLevel : MonoBehaviour
	{
		public void LoadNextLevel()
		{
			LoaderManager.Get().LoadScene("Loader 02");
			UILoadingScreen.Get().SetVisible(true);
		}

	}
}