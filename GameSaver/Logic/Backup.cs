using GameSaver.Model;
using System.Threading.Tasks;

namespace GameSaver.Logic
{
    /// <summary>
    /// Managing thread for creating and restoring backups.
    /// </summary>
    class Backup
    {
        /// <summary>
        /// Create a new backup using the provided game profile and backupName
        /// </summary>
        /// <param name="profile">Profile to make a backup of</param>
        /// <param name="backupName">User provided name of the backup file</param>
        /// <returns>True if the backup was created</returns>
        public async Task<bool> CreateBackup(GameProfile profile, string backupName)
        {
            return await Task.FromResult(false);
        }

        /// <summary>
        /// Restore a backup from file
        /// </summary>
        /// <param name="backup">The backup file to use</param>
        /// <returns>True if the restore was successful</returns>
        public async Task<bool> RestoreBackup(BackupFile backup)
        {
            return await Task.FromResult(false);
        }

        /// <summary>
        /// Removes all files and folders from the game profile
        /// </summary>
        /// <param name="profile">Profile to use</param>
        /// <returns>True if the delete worked</returns>
        public async Task<bool> WipeSaves(GameProfile profile)
        {
            return await Task.FromResult(false);
        }

        /// <summary>
        /// Deletes a backup file from disk and our index
        /// </summary>
        /// <param name="backup">File to delete</param>
        /// <returns>True if the backup was entirely removed</returns>
        public async Task<bool> DeleteBackup(BackupFile backup)
        {
            return await Task.FromResult(false);
        }

    }
}
