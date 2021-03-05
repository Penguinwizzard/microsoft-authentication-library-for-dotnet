// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Identity.Client.Core;
using Microsoft.Identity.Client.Internal.Logger;
using Microsoft.Identity.Client.PlatformsCommon.Factories;

namespace Microsoft.Identity.Client
{
  
    /// <summary>
    /// 
    /// </summary>
    public class WindowsBrokerOptions
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WindowsBrokerOptions()
        {
            ValidatePlatformAvailability();
        }

        /// <summary>
        /// 
        /// </summary>
        public bool MsaPassthroughUsingPicker { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        public bool ListWindowsAccounts { get; set; } = false;

        internal void LogParameters(ICoreLogger logger)
        {
            logger.Info("DefaultBrowserOptions configured");
        }

        internal static void ValidatePlatformAvailability()
        {
#if __MOBILE__
            throw new MsalClientException("not_supported", "These options only affect the Windows 10 Broker");
#endif
        }


    }
}
