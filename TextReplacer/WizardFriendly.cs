﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReplacer
{
    public interface WizardFriendly
    {
        void addWordPair_Wizard(string targetText, string newText);
    }
}