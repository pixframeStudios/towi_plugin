
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using PixframeStudios.TowiPlugin;

[CustomEditor(typeof(TowiGameManager))]
public class TowiGameManagerEditor : Editor
{
    protected bool showGameInfo = false;
    public override void OnInspectorGUI()
    {
        TowiGameManager towiGameManager = (TowiGameManager)target;

        showGameInfo = EditorGUILayout.Foldout(showGameInfo, "GameSettings");
        if (showGameInfo) 
        {
            towiGameManager.gameName = EditorGUILayout.TextField("Game Name", towiGameManager.gameName);
            towiGameManager.rounds = EditorGUILayout.IntField("Number of game rounds", towiGameManager.rounds);
            towiGameManager.pointsPerRound = EditorGUILayout.IntField("Points per round", towiGameManager.pointsPerRound);
        }
    }
}
