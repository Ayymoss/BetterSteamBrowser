﻿using BetterSteamBrowser.Domain.Enums;

namespace BetterSteamBrowser.Domain.Interfaces.Services;

public interface ISignalRNotification
{
    Task NotifyUsersAsync(HubType hubType, string methodName, object message, CancellationToken cancellationToken);
}
