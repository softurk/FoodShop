﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melake.Data
{
    public interface INetworkConnection
    {

        bool IsConnected { get; }

        void CheckNetworkConnection();
    }
}
