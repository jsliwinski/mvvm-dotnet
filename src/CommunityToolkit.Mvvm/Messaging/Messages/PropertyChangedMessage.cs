// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This file is inspired from the MvvmLight library (lbugnion/MvvmLight),
// more info in ThirdPartyNotices.txt in the root of the project.

namespace CommunityToolkit.Mvvm.Messaging.Messages;

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This file is inspired from the MvvmLight library (lbugnion/MvvmLight),
// more info in ThirdPartyNotices.txt in the root of the project.

/// <summary>
/// A message used to broadcast property changes in observable objects.
/// </summary>
public class PropertyChangedMessage
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PropertyChangedMessage"/> class.
    /// </summary>
    /// <param name="sender">The original sender of the broadcast message.</param>
    /// <param name="propertyName">The name of the property that changed.</param>
    /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="sender"/> is <see langword="null"/>.</exception>
    public PropertyChangedMessage(object sender, string? propertyName)
    {
        ArgumentNullException.ThrowIfNull(sender);

        Sender = sender;
        PropertyName = propertyName;
    }

    /// <summary>
    /// Gets the original sender of the broadcast message.
    /// </summary>
    public object Sender { get; }

    /// <summary>
    /// Gets the name of the property that changed.
    /// </summary>
    public string? PropertyName { get; }
}