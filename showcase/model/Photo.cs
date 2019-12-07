using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Showcase {
    [DataContract (Name = "photo")]
    [ExcludeFromCodeCoverage]
    public class Photo {

        [DataMember (Name = "albumId")]
        public int AlbumId { get; set; }

        [DataMember (Name = "id")]
        public int Id { get; set; }

        [DataMember (Name = "title")]
        public string Title { get; set; }

        [DataMember (Name = "url")]
        public string URL { get; set; }

        [DataMember (Name = "thumbnailurl")]
        public string ThumbnailUrl { get; set; }

    }
}