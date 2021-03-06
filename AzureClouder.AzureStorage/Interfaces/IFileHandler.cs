﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureClouders.AzureStorage.Interfaces
{
    /// <summary>
    /// Interface with File Handling
    /// </summary>
    public interface IFileHandler
    {
        /// <summary>
        /// Save files in a File System
        /// </summary>
        /// <param name="files">File List</param>
        /// <returns>Saved files paths</returns>
        Task<IEnumerable<string>> SaveFilesAsync(IEnumerable<IFormFile> files);

        /// <summary>
        /// Save file in a File System
        /// </summary>
        /// <param name="file">File</param>
        /// <returns>Saved file paths</returns>
        Task<string> SaveFileAsync(IFormFile file);

        /// <summary>
        /// Removes files with given paths
        /// </summary>
        /// <param name="fileNames">File paths to remove</param>
        Task RemoveFilesAsync(IEnumerable<string> fileNames);

        /// <summary>
        /// Removes file with given paths
        /// </summary>
        /// <param name="fileName">File path to remove</param>
        Task RemoveFileAsync(string fileName);
    }
}