﻿/*
   Copyright (C) 2016 Alexey Lavrenchenko (http://prosecuritiestrading.com/)

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;

namespace ProSecuritiesTrading.MOEX.FIX.Base.Field
{
    public class TrdSubType
    {
        public const int Tag = 829;
        public static readonly byte[] TagBytes;

        static TrdSubType()
        {
            TagBytes = new byte[3];
            TagBytes[0] = 56;
            TagBytes[1] = 50;
            TagBytes[2] = 57;
        }
    }
}
