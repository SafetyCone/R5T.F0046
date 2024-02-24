using System;


namespace R5T.F0046
{
    public static class Instances
    {
        public static L0066.ICharacters Characters { get; } = L0066.Characters.Instance;
        public static F0047.IGitHubOwnerOperator GitHubOwnerOperator { get; } = F0047.GitHubOwnerOperator.Instance;
        public static F0044.INameOperator NameOperator => F0044.NameOperator.Instance;
        public static IRepositoryDescriptionOperator RepositoryDescriptionOperator { get; } = F0046.RepositoryDescriptionOperator.Instance;
        public static IRepositoryNameOperator RepositoryNameOperator { get; } = F0046.RepositoryNameOperator.Instance;
        public static L0066.IStrings Strings { get; } = L0066.Strings.Instance;
    }
}