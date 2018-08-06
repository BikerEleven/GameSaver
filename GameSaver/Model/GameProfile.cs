using System;

namespace GameSaver.Model
{
    /// <summary>
    /// Data class representing a Game Profile (Save Folder)
    /// </summary>
    class GameProfile
    {
        public readonly Guid id;
        public string FilePath { get; set; }
        public string Name { get; set; }

        public GameProfile()
        {
            id = Guid.NewGuid();
        }

        public GameProfile(string path, string nname)
        {
            id = Guid.NewGuid();
            FilePath = path;
            Name = nname;
        }

    }
}
