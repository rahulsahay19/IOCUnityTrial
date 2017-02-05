using System.Runtime.Serialization;

namespace WcfUnityTrial.Model
{
    [DataContract]
    public class Movie
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string MovieName { get; set; }
        [DataMember]
        public string DirectorName { get; set; }
        [DataMember]
        public string ReleaseYear { get; set; }
    }
}