using MoviesAndTV.Components.GoT.Domain;

namespace MoviesAndTV.Components.GoT.Interfaces
{
    public interface IProvider
    {
        Task<Character> GetCharacter(string name);
    }
}
