﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Linq;

namespace TheS.SperfGames.MayaTukky
{
    /// <summary>
    /// ตัวควบคุม Stage 1
    /// </summary>
    public class GameStageManagerFirst : GameStageManager
    {
        /// <summary>
        /// สร้างระดับความยากของเกมตอนเริ่มต้น
        /// </summary>
        public GameStageManagerFirst()
        {
            _gameLevels = new System.Collections.Generic.List<GameLevel>()
            {
                new GameLevelFirstFix(3,3,100,2.0f,1,"1"),
                new GameLevelFirstFix(3,4,150,2.0f,2,"1"),
                new GameLevelFirstFix(3,5,200,2.0f,3,"1"),
                new GameLevelFirstFix(4,4,250,2.0f,4,"1"),
                new GameLevelFirstFix(4,5,300,2.0f,5,"2"),
                new GameLevelFirstFix(4,6,350,2.0f,6,"2"),
                new GameLevelFirstFix(4,7,400,2.0f,7,"3"),
                new GameLevelFirstFix(5,5,450,2.0f,8,"3"),
                new GameLevelFirstFix(5,6,500,2.0f,9,"4"),
                new GameLevelFirstFix(5,7,550,2.0f,10,"4"),
            };
            _currentLevel = _gameLevels.First();

            const int AddTimeSecond = 10;
            const float AddPluseCombo = 0.2f;
            _timeCombo = new TimeCombo(AddTimeSecond);
            _gameCombo = new GameCombo(AddPluseCombo);
        }

        //เพิ่มความยาก
        protected override GameLevel nextLevel()
        {
            GameLevel newGameLevel = null;
            const int MaximumLevel = 9;
            if (_currentLevelIndex <= MaximumLevel)
            {
                _currentLevelIndex++;
                _gameLevels[_currentLevelIndex].IsLevelUp = true;
                newGameLevel = _gameLevels[_currentLevelIndex];
            }
            else
            {
                newGameLevel = new GameLevelFirstCompute(true, _currentLevelIndex);
            }

            return newGameLevel;
        }

        //ลดความยาก
        protected override GameLevel previousLevel()
        {
            const int MinimumLevel = 0;
            if (_currentLevelIndex > MinimumLevel) _currentLevelIndex--;
            _gameLevels[_currentLevelIndex].IsLevelUp = false;

            return _gameLevels[_currentLevelIndex];
        }
    }
}
