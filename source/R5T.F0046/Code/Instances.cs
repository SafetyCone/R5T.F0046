using System;

using R5T.F0047;
using R5T.Z0000;


namespace R5T.F0046
{
    public static class Instances
    {
        public static ICharacters Characters { get; } = Z0000.Characters.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator { get; } = F0047.GitHubOwnerOperator.Instance;
        public static IRepositoryDescriptionOperator RepositoryDescriptionOperator { get; } = F0046.RepositoryDescriptionOperator.Instance;
        public static IRepositoryNameOperator RepositoryNameOperator { get; } = F0046.RepositoryNameOperator.Instance;
        public static IStrings Strings { get; } = Z0000.Strings.Instance;
    }
}