using System;
using System.Runtime.Serialization;

namespace Showcase {
    [DataContract (Name = "photo")]
    public class Photo {

        private int _albumId;
        [DataMember (Name = "albumId")]
        public int AlbumId {
            get { return this._albumId; }
            set { this._albumId = value; }
        }

        private int _id;
        [DataMember (Name = "id")]
        public int Id {
            get { return this._id; }
            set { this._id = value; }
        }

        private string _title;
        [DataMember (Name = "title")]
        public string Title {
            get { return this._title; }
            set { this._title = value; }
        }
        private string _url;
        [DataMember (Name = "url")]
        public string URL {
            get { return this._url; }
            set { this._url = value; }
        }
        private string _thumbnailUrl;
        [DataMember (Name = "thumbnailurl")]
        public string ThumbnailUrl {
            get { return this._thumbnailUrl; }
            set { this._thumbnailUrl = value; }
        }

    }
}