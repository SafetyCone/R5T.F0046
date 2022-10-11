using System;


namespace R5T.F0046
{
	public class RepositoryDescriptionOperator : IRepositoryDescriptionOperator
	{
		#region Infrastructure

	    public static IRepositoryDescriptionOperator Instance { get; } = new RepositoryDescriptionOperator();

	    private RepositoryDescriptionOperator()
	    {
        }

	    #endregion
	}
}