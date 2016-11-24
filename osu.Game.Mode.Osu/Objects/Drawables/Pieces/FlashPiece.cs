﻿using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using OpenTK;

namespace osu.Game.Modes.Osu.Objects.Drawables.Pieces
{
    public class FlashPiece : Container
    {
        public FlashPiece()
        {
            Size = new Vector2(144);

            Masking = true;
            CornerRadius = Size.X / 2;

            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;

            BlendingMode = BlendingMode.Additive;
            Alpha = 0;

            Children = new Drawable[]
            {
                new Box
                {
                    RelativeSizeAxes = Axes.Both
                }
            };
        }
    }
}