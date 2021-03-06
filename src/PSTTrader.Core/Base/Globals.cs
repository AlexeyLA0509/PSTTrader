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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Reflection;

using ProSecuritiesTrading.PSTTrader.Core.Connection;

namespace ProSecuritiesTrading.PSTTrader.Core.Base
{
    public class Globals
    {
        private static ConnectionCollection connections = new ConnectionCollection();
        private static List<ConnectionSettings> connectionSettingsCollection = new List<ConnectionSettings>();
        private static ObservableCollection<ConnectionItem> connectionItems = new ObservableCollection<ConnectionItem>();
        private static List<Instrument> instruments = new List<Instrument>();
        private static List<Assembly> connectionAssemblies = new List<Assembly>();

        public static ConnectionCollection Connections
        {
            get
            {
                return connections;
            }
        }

        public static List<ConnectionSettings> ConnectionSettingsCollection
        {
            get
            {
                return connectionSettingsCollection;
            }
        }

        public static ObservableCollection<ConnectionItem> ConnectionItems
        {
            get
            {
                return connectionItems;
            }
        }

        public static List<Instrument> Instruments
        {
            get
            {
                return instruments;
            }
        }

        public static List<Assembly> ConnectionAssemblies
        {
            get
            {
                return connectionAssemblies;
            }
        }
    }
}
