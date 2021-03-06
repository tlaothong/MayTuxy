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
using System.Collections.Generic;

namespace TheS.SperfGames.MayaTukky
{
    /// <summary>
    /// ตารางข้อมูลของ Appo
    /// </summary>
    public class ScoreTableResponse
    {
        #region Properties

        /// <summary>
        /// ลำดับชั้นของการ์ด
        /// </summary>
        public IEnumerable<CardInformation> CardLevelList { get; set; }

        #endregion Properties
    }
}
