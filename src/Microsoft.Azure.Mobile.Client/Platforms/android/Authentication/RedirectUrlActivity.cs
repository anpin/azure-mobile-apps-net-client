// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using Android.App;
using Microsoft.Maui.Authentication;

namespace Microsoft.WindowsAzure.MobileServices
{
    /// <summary>
    /// Activity class for the callback from the authentication process.
    /// </summary>
    [Activity(Name = "com.microsoft.windowsazure.mobileservices.authentication.RedirectUrlActivity")]
    public class RedirectUrlActivity : WebAuthenticatorCallbackActivity
    {

    }
}
