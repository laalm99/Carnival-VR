﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UxrPostUpdateMode.cs" company="VRMADA">
//   Copyright (c) VRMADA, All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using UltimateXR.Avatar;
using UnityEngine;

namespace UltimateXR.Core
{
    /// <summary>
    ///     Enumerates where <see cref="UxrManager" /> updates the <see cref="UxrAvatar" /> post-update. Among elements
    ///     processed in the post-update is the animation. See <see cref="UxrManager.PostUpdateMode" />
    /// </summary>
    public enum UxrPostUpdateMode
    {
        /// <summary>
        ///     Don't update.
        /// </summary>
        None,

        /// <summary>
        ///     Update on <see cref="UxrManager" />'s Update(). If the <see cref="UxrAvatar" /> has any <see cref="Animator" />
        ///     components, these will override any animation or hand poses generated by UltimateXR.
        /// </summary>
        Update,

        /// <summary>
        ///     Update on <see cref="UxrManager" />'s LateUpdate(). If the <see cref="UxrAvatar" /> has any <see cref="Animator" />
        ///     components, UltimateXR animation or hand poses will prevail.
        /// </summary>
        LateUpdate
    }
}