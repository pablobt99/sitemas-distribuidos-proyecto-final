﻿using System;
using System.Drawing;

namespace Backend
{
    /// <summary>
    /// Class ImageModelEventArgs used to send arguments through events to the View to update data for rendering
    /// </summary>
    public class ImageModelEventArgs : EventArgs
    {
        /// <summary>
        /// Property to hold the updated image (if any)
        /// </summary>
        public Image Img { get; }

        /// <summary>
        /// Property to hold the updated width (if any)
        /// </summary>
        public int Width { get; }
        /// <summary>
        /// Property to hold the updated height (if any)
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Property to hold the updated rotating in degrees (if any)
        /// </summary>
        public int Degrees { get; }

        /// <summary>
        /// Constructor for ImageModelEventArgs that takes in the updated Image
        /// </summary>
        /// <param name="image">The image</param>
        public ImageModelEventArgs(Image image)
        {
            Img = image;
        }

        /// <summary>
        /// Constructor for ImageModelEventArgs that takes in the updated image size
        /// </summary>
        /// <param name="width">The new width</param>
        /// <param name="height">The new height</param>
        public ImageModelEventArgs(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Constructor for ImageModelEventArgs that takes in the updated image rotating
        /// </summary>
        /// <param name="degrees">The new degrees value</param>
        public ImageModelEventArgs(int degrees)
        {
            Degrees = degrees;
        }
    }
}