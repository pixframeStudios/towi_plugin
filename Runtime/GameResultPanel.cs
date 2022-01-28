namespace PixframeStudios.TowiPlugin
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;

    public class GameResultPanel : MonoBehaviour
    {
        public TextMeshProUGUI text;
        public Image[] calificationImages;
        public Button okButton;
        public Color offColor { get => m_offColor; }
        public Color onColor { get => m_onColor; }
        [SerializeField] protected Color m_offColor = new Color(0.2f, 0.2f, 0.2f, 0.8f);
        [SerializeField] protected Color m_onColor = Color.yellow;

        public void ShowCalification(GameResult result)
        {
            if (calificationImages.Length < (int)GameResult.Excellent)
            {
                Debug.LogError("You need at least 3 images to represent the califiction");
                return;
            }

            for (int i = 0; i < (int)GameResult.Excellent; i++)
            {
                if (i < (int)result)
                {
                    calificationImages[i].color = Color.white;
                    continue;
                }
                calificationImages[i].color = offColor;
            }
        }
    }
}
