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
        [SerializeField] protected List<string> tutorialText;
        protected List<string> confirmationText;
        protected List<string> positiveRoundResultText;
        protected List<string> negativeRoundResultText;
        protected List<string> finalPositiveResultText;
        protected List<string> finaNegativelResultText;
        protected List<string> bonusText;

        private void Start()
        {
            Init();
        }

        protected virtual void ShowInitialText()
        {
            
        }

        #region Helpers

        protected virtual void SceneInitialization()
        {
            //Useful for change StartMenu to InitialText
        }

        protected virtual void GameInitialization()
        {
            //Useful for change from InitialText to tutorial text
        }

        protected virtual void ExplainGame()
        {
            //Useful for showing the tutorial text and images
        }

        protected virtual void SetGameObjectives()
        {
            //Useful for setting up the rounds, objectives and bonus
        }
        protected virtual void BeginGame()
        {
            //Useful for setting up the things that will appear on the game scene, and making the game loop
        }
        protected virtual void ShowResult()
        {
            //Useful for check and verify the score, the actualRound, the levels and showing it on the next screen
        }

        #endregion
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
