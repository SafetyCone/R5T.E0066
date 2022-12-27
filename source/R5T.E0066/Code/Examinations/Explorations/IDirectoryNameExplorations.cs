using System;

using R5T.T0141;


namespace R5T.E0066
{
    [ExplorationsMarker]
    public partial interface IDirectoryNameExplorations : IExplorationsMarker
    {
        /// <summary>
        /// See also: R5T.Q0000.IPathExplorations.DescribeInvalidPathAndFileNameCharacters().
        /// </summary>
        public void DescribeInvalidFileNameCharactersToFile()
        {
            /// Inputs.
            var outputFilePath = Instances.FilePaths.OutputTextFilePath;


            /// Run.
            var invalidFileNameCharacters = Instances.PathOperator.GetInvalidFileNameCharacters();

            Instances.CharacterOperator.DescribeToFile_Synchronous(
                outputFilePath,
                invalidFileNameCharacters);

            Instances.NotepadPlusPlusOperator.Open(
                outputFilePath);
        }
    }
}
