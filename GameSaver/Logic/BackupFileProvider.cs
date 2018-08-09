using System;
using System.Collections.Generic;
using System.Linq;
using GameSaver.Model;

namespace GameSaver.Logic
{
    /// <summary>
    /// Manages and tracks created backup files.
    /// </summary>
    class BackupFileProvider
    {

        private Dictionary<Guid, List<BackupFile>> files;
        private static BackupFileProvider instance;

        /// <summary>
        /// Load the data from file or create a new empty data set.
        /// </summary>
        private BackupFileProvider()
        {

        }

        /// <summary>
        /// Load the dictionary of BackupFiles from the binary file
        /// </summary>
        private void LoadFromFile()
        {

        }

        /// <summary>
        /// Save the dictionary of BackupFiles to the binary file
        /// </summary>
        private void SaveToFile()
        {

        }


        /// <summary>
        /// Return a enumerator for the backup files in our collection
        /// </summary>
        /// <param name="byProfile">GameProfile to filter by</param>
        /// <returns>Enumerator of BackupFiles relating to the provided profile</returns>
        public IReadOnlyList<BackupFile> GetFiles(Guid byProfile)
        {
            if (files.TryGetValue(byProfile, out List<BackupFile> ilist))
            {
                return ilist;
            }

            return new List<BackupFile>(0);
        }

        /// <summary>
        /// Add a new backup to our tracking collection
        /// </summary>
        /// <param name="newFile">New file to add</param>
        public void AddBackupFile(BackupFile newFile)
        {

        }

        /// <summary>
        /// Remove a backup file from our tracking collection
        /// </summary>
        /// <param name="file">File to remove</param>
        public void RemoveBackupFile(BackupFile file)
        {
            
        }

        /// <summary>
        /// This will remove all the backups associated with a game profile.
        /// </summary>
        /// <param name="profileID">The profile to remove from our storage</param>
        internal void DeleteBranch(Guid profileID)
        {
            if (files.ContainsKey(profileID))
            {
                foreach (var bak in GetFiles(profileID)) RemoveBackupFile(bak);
                files.Remove(profileID);
            }
        }

        /// <summary>
        /// Cleanup
        /// </summary>
        ~BackupFileProvider()
        {

        }

        /// <summary>
        /// Creates a new BackupFileProvider that will persist over the program lifespan
        /// </summary>
        /// <returns>The newly created provider</returns>
        public static BackupFileProvider CreateProvider()
        {
            if (instance != null)
                throw new InvalidOperationException("There is already an existing BackupFileProvider");

            instance = new BackupFileProvider();
            instance.LoadFromFile();
            return instance;
        }

        /// <summary>
        /// Returns the the persisting BackupFileProvider
        /// </summary>
        /// <returns>The persisting BackupFileProvider</returns>
        public static BackupFileProvider GetProvider()
        {
            if (instance == null)
                throw new InvalidOperationException("The BackupFileProvider was never created");
            return instance;
        }

    }
}
