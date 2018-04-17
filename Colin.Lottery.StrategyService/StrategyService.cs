﻿using System;
using System.Collections.Generic;
using Colin.Lottery.Models;

namespace Colin.Lottery.StrategyService
{
    public abstract class StrategyService<T>
        : Singleton<T>, IStrategyService
        where T : StrategyService<T>, new()
    {
        public abstract void Start();

        public abstract void Start(Dictionary<LotteryType, List<int>> typeRules);
    }
}