using System;


namespace R5T.E0066
{
    public class DirectoryNameExplorations : IDirectoryNameExplorations
    {
        #region Infrastructure

        public static IDirectoryNameExplorations Instance { get; } = new DirectoryNameExplorations();


        private DirectoryNameExplorations()
        {
        }

        #endregion
    }
}
