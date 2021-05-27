using DVJ02.Semana09;
using UnityEngine.UI;

namespace DVJ02.Semana10
{
	public class UILoadingScreen : MonoBehaviourSingleton<UILoadingScreen>
	{
		public Text loadingText;

		public override void Awake()
		{
			base.Awake();
			gameObject.SetActive(false);
		}

		public void SetVisible(bool show)
		{
			gameObject.SetActive(show);
		}

		public void Update()
		{
			int loadingVal = (int)(LoaderManager.Get().loadingProgress * 100);
			loadingText.text = "Loading " + loadingVal;
			if (LoaderManager.Get().loadingProgress >= 1)
				SetVisible(false);
		}

	}
}