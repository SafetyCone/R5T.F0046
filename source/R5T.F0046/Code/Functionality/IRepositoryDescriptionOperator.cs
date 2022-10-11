using System;

using R5T.T0132;


namespace R5T.F0046
{
	[FunctionalityMarker]
	public partial interface IRepositoryDescriptionOperator : IFunctionalityMarker
	{
		public string GetRepositoryDescription_FromLibraryDescription(string libraryDescription)
		{
			// The repository description is just the library description.
			var output = libraryDescription;
			return output;
		}
	}
}