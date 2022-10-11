using System;

using R5T.T0132;


namespace R5T.F0046
{
	[FunctionalityMarker]
	public partial interface IRepositoryOperator : IFunctionalityMarker
	{
		public string GetOwnedRepositoryName(
			string repositoryName,
			string ownerName)
        {
			var ownedRepositoryName = Instances.RepositoryNameOperator.GetOwnedRepositoryName(
				ownerName,
				repositoryName);

			return ownedRepositoryName;
		}

		public string GetRepositoryName(string libraryName)
        {
			var repositoryName = Instances.RepositoryNameOperator.GetRepositoryName_FromLibraryName(libraryName);
			return repositoryName;
		}

		public RepositoryDescriptors GetDescriptors(
			string libraryName,
			string libraryDescription,
			string ownerName)
        {
			var repositoryName = this.GetRepositoryName(libraryName);	
			var repositoryDescription = Instances.RepositoryDescriptionOperator.GetRepositoryDescription_FromLibraryDescription(libraryDescription);

			var ownedRepositoryName = this.GetOwnedRepositoryName(
				repositoryName,
				ownerName);

			var repositoryDescriptors = new RepositoryDescriptors
			{
				Name = repositoryName,
				OwnedName = ownedRepositoryName,
				Description = repositoryDescription,
			};

			return repositoryDescriptors;
		}
	}
}