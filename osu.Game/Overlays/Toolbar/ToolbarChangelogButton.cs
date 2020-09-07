// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;

namespace osu.Game.Overlays.Toolbar
{
    public class ToolbarChangelogButton : ToolbarOverlayToggleButton
    {
        [BackgroundDependencyLoader(true)]
        private void load(ChangelogOverlay changelog)
        {
            StateContainer = changelog;
        }
    }
}
