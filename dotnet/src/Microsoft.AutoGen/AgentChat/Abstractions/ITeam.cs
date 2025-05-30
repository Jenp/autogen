// Copyright (c) Microsoft Corporation. All rights reserved.
// ITeam.cs

using Microsoft.AutoGen.Contracts;

namespace Microsoft.AutoGen.AgentChat.Abstractions;

/// <summary>
/// A team of agents.
/// </summary>
public interface ITeam : ITaskRunner, ISaveState
{
    /// <summary>
    /// Reset the team and all its participants to its initial state.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
    ValueTask ResetAsync(CancellationToken cancellationToken = default);
}
