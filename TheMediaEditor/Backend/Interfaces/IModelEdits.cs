﻿using System.Drawing;

namespace Backend
{
    /// <summary>
    /// Interface for ModelEdits - Contains methods for editing images
    /// </summary>
    public interface IModelEdits
    {
        /// <summary>
        /// Scale and image
        /// </summary>
        /// <param name="size">The new size the image should be scaled to</param>
        void Resize(Size size);

        /// <summary>
        /// Rotate an image
        /// </summary>
        /// <param name="degrees">The amount the image should be rotate by (in degrees)</param>
        void Rotate(int degrees);

        /// <summary>
        /// Flip an image
        /// </summary>
        /// <param name="flipVertically">If the image should be flipped vertically or horizontally</param>
        void Flip(bool flipVertically);

        /// <summary>
        /// Filter an image applying a specific MatrixFilter
        /// </summary>
        void FilterOriginal();
        void FilterBlackWhite();
        void FilterComic();
        void FilterLomograph();
        void FilterSepia();
        void FilterInvert();

        /// <summary>
        /// Applies a certain amount of contrast to an image
        /// </summary>
        /// <param name="percentage">The percentage of contrast to apply</param>
        void Contrast(int percentage);

        /// <summary>
        /// Applies a certain amount of brightness to an image
        /// </summary>
        /// <param name="percentage">The percentage of brightness to apply</param>
        void Brightness(int percentage);

        /// <summary>
        /// Applies a certain amount of saturation to an image
        /// </summary>
        /// <param name="percentage">The percentage of saturation to apply</param>
        void Saturation(int percentage);

        /// <summary>
        /// Resets the edits made to the image
        /// </summary>
        void ResetEdits();
    }
}
