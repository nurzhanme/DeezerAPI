using System;

namespace DeezerAPI.Models
{
    public class Metadata : Track
    {
        /// <summary>
        /// Track MD5 Hash
        /// </summary>
        public string MD5 { get; set; }
        /// <summary>
        /// Track Media Version
        /// </summary>
        public string MediaVersion { get; set; }
        /// <summary>
        /// Track Quality
        /// </summary>
        public int Quality { get; set; }

        /// <summary>
        /// Generate Track Art URL
        /// </summary>
        /// <returns></returns>
        public Uri GenerateImageUrl()
        {
            if (!string.IsNullOrEmpty(albumart))
            {
                return new Uri("https://cdns-images.dzcdn.net/images/cover/" + albumart + "/264x264-000000-80-0-0.jpg");
            }
            else
            {
                return null;
            }
        }
    }
}
