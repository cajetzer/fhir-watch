﻿using FhirBlaze.SharedComponents;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;

namespace FhirBlaze
{
    public class BackendAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public BackendAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigationManager,
            ApiConnection connection
            )
            : base(provider, navigationManager)
        {
            ConfigureHandler(
                authorizedUrls: new[] { connection.BaseUri },
                scopes: new[] { connection.Scope }
                );
        }
    }
}
