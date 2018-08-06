using GameSaver.Model;
using System;
using System.Collections.Generic;

namespace GameSaver.Logic
{
    class GameProfileProvider
    {
        private Dictionary<Guid, GameProfile> files;
        private static GameProfileProvider instance;

        /// <summary>
        /// Load the data from file or create a new empty data set.
        /// </summary>
        private GameProfileProvider()
        {

        }

        /// <summary>
        /// Load the dictionary of profiles from the binary file
        /// </summary>
        private void LoadFromFile()
        {

        }

        /// <summary>
        /// Save the dictionary of profiles to the binary file
        /// </summary>
        private void SaveToFile()
        {

        }

        /// <summary>
        /// Return a enumerator for the profiles in our collection
        /// </summary>
        /// <returns>Enumerator of profiles</returns>
        public IEnumerator<GameProfile> GetProfiles()
        {
            return files.Values.GetEnumerator();
        }

        /// <summary>
        /// Add a new profile to our tracking collection. This will not modify an existing profile.
        /// </summary>
        /// <param name="newProfile">Profile to add</param>
        public void AddProfile(GameProfile newProfile)
        {

        }

        /// <summary>
        /// Remove a profile from our tracking collection
        /// </summary>
        /// <param name="profile">Profile to remove</param>
        public void RemoveBackupFile(GameProfile profile)
        {

        }

        /// <summary>
        /// Replace a GameProfile in our collection with an updated version
        /// </summary>
        /// <param name="profileID">Id of existing game profile to edit</param>
        /// <param name="modified">Modified profile data</param>
        public void ModifyBackupFile(Guid profileID, GameProfile modified)
        {

        }

        /// <summary>
        /// Cleanup
        /// </summary>
        ~GameProfileProvider()
        {
            
        }

        /// <summary>
        /// Creates a new GameProfileProvider that will persist over the program lifespan
        /// </summary>
        /// <returns>The newly created provider</returns>
        public static GameProfileProvider CreateProvider()
        {
            if (instance != null)
                throw new InvalidOperationException("There is already an existing GameProfileProvider");

            instance = new GameProfileProvider();
            instance.LoadFromFile();
            return instance;
        }

        /// <summary>
        /// Returns the the persisting GameProfileProvider
        /// </summary>
        /// <returns>The persisting GameProfileProvider</returns>
        public static GameProfileProvider GetProvider()
        {
            if (instance == null)
                throw new InvalidOperationException("The GameProfileProvider was never created");
            return instance;
        }
    }
}
