namespace PixframeStudios.TowiPlugin
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class TowiGameManager : MonoBehaviour
    {
        public static TowiGameManager instance;

        protected GamePhase phase = GamePhase.Initialization;

        [Header("Game configuration")]
        public string gameName = "Name of the game in towi db";
        public int rounds = 3;
        public int pointsPerRound = 1;
        protected float score;
        protected int historyIndex = 0;

        [SerializeField] protected TextAsset asset;
        //This list will be usefull for giving instrctions and objectives to players
        [SerializeField] protected List<string> initialText;
        protected List<string> tutorialText;
        protected List<string> confrimationText;
        protected List<string> positiveRoundResultText;
        protected List<string> negativeRoundResultText;
        protected List<string> finalPositiveResultText;
        protected List<string> finaNegativelResultText;

        private void Start()
        {
            Init();
        }

        protected virtual void ShowInitialText()
        {
            
        }

        protected void Init()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void OnDestroy()
        {
            if (instance == this)
            {
                instance = null;
            }
        }
    }
}
