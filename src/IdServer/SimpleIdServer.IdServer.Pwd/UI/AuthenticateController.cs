﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using MassTransit;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SimpleIdServer.IdServer.Helpers;
using SimpleIdServer.IdServer.Jwt;
using SimpleIdServer.IdServer.Options;
using SimpleIdServer.IdServer.Pwd;
using SimpleIdServer.IdServer.Pwd.Services;
using SimpleIdServer.IdServer.Store;
using SimpleIdServer.IdServer.UI.Services;
using SimpleIdServer.IdServer.UI.ViewModels;

namespace SimpleIdServer.IdServer.UI;

[Area(Constants.Areas.Password)]
public class AuthenticateController : BaseAuthenticationMethodController<AuthenticatePasswordViewModel>
{
    private readonly IConfiguration _configuration;

    public AuthenticateController(
        IPasswordAuthenticationService userAuthenticationService,
        IAuthenticationSchemeProvider authenticationSchemeProvider,
        IOptions<IdServerHostOptions> options,
        IDataProtectionProvider dataProtectionProvider,
        ITokenRepository tokenRepository,
        IJwtBuilder jwtBuilder,
        IAuthenticationHelper authenticationHelper,
        IClientRepository clientRepository,
        IAmrHelper amrHelper,
        IUserRepository userRepository,
        IUserSessionResitory userSessionRepository,
        IUserTransformer userTransformer,
        IBusControl busControl,
        IConfiguration configuration,
        IAntiforgery antiforgery,
        IAuthenticationContextClassReferenceRepository authenticationContextClassReferenceRepository) : base(options, authenticationSchemeProvider, userAuthenticationService, dataProtectionProvider, tokenRepository, jwtBuilder, authenticationHelper, clientRepository, amrHelper, userRepository, userSessionRepository, userTransformer, busControl, antiforgery, authenticationContextClassReferenceRepository)
    {
        _configuration = configuration;
    }

    protected override string Amr => Constants.Areas.Password;

    protected override bool IsExternalIdProvidersDisplayed => true;

    protected override Task<UserAuthenticationResult> CustomAuthenticate(string prefix, string authenticatedUserId, AuthenticatePasswordViewModel viewModel, CancellationToken cancellationToken)
    {
        return Task.FromResult(UserAuthenticationResult.Ok());
    }

    protected override bool TryGetLogin(AmrAuthInfo amrInfo, out string login)
    {
        login = amrInfo.Login;
        return true;
    }

    protected override void EnrichViewModel(AuthenticatePasswordViewModel viewModel)
    {
        var options = GetOptions();
        viewModel.CanResetPassword = options.CanResetPassword;
    }

    private IdServerPasswordOptions GetOptions()
    {
        var section = _configuration.GetSection(typeof(IdServerPasswordOptions).Name);
        return section.Get<IdServerPasswordOptions>();
    }
}
