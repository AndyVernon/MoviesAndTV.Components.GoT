namespace MoviesAndTV.Components.GoT.Configuration
{
    internal class APIConfiguration
    {
        public string? BaseUri { get; set; }
        public Endpoints? Endpoints { get; set; }
    }

    internal class Endpoints
    {
        public string? Get { get; set; }
        public string? GetCharacter { get; set; }
        public string? GetActor { get; set; }
    }
}
