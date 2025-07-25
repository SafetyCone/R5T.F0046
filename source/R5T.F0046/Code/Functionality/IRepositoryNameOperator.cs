using System;

using R5T.T0132;


namespace R5T.F0046
{
	[FunctionalityMarker]
	public partial interface IRepositoryNameOperator : IFunctionalityMarker,
		F0044.IRepositoryNameOperator
	{
		public string GetOwnedRepositoryName(string ownerName, string repositoryName)
		{
			var output = $"{ownerName}{Instances.Characters.Slash}{repositoryName}";
			return output;
		}

		public string GetRepositoryName_FromLibraryName(string libraryName)
		{
			// Repository name is just the library name.
			var output = libraryName;
			return output;
		}

		/// <summary>
		/// Get the repository name using the owner name and Natter repository 4-digit code.
		/// Example: "R5T.F0033" is the result of the "SafetyCone" owner (which is turned into the organization namespace token "R5T") and "F0033".
		/// </summary>
		/// <param name="owner">The owner name from <see cref="F0047.IGitHubOwners"/> recognized by <see cref="F0047.IGitHubOwnerOperator.Get_OrganizationNamespaceToken(string)"/>. Example: "SafetyCone".</param>
		/// <param name="natterRepositoryCode">The repository code. Example: "F0033"></param>
		/// <returns>The repository name. Example: "R5T.F0033".</returns>
		public string GetRepositoryName(
			string owner,
			string natterRepositoryCode)
		{
			var separatorToken = this.GetSeparatorToken();
			var organizationNamespaceToken = Instances.GitHubOwnerOperator.Get_OrganizationNamespaceToken(owner);

			var repositoryName = $"{organizationNamespaceToken}{separatorToken}{natterRepositoryCode}";
			return repositoryName;
		}

		/// <summary>
		/// Returns the repository name separator token, which is a period ('.', <see cref="L0066.IStrings.Period"/>).
		/// </summary>
		public string GetSeparatorToken()
		{
			var separatorToken = Instances.Strings.Period;
			return separatorToken;
		}
	}
}