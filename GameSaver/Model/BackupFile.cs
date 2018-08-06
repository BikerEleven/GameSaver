using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaver.Model
{
    /// <summary>
    /// Data class representing a backup for a game save folder.
    /// Note: This is an immutable class
    /// </summary>
    class BackupFile
    {
        public readonly Guid id;
        public readonly Guid gameId;
        public readonly string filePath;
        public readonly string name;

        public BackupFile(Guid pid, string path, string nname)
        {
            id = Guid.NewGuid();
            gameId = pid;
            filePath = path;
            name = nname;
        }

    }
}
