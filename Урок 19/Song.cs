﻿

using System.Data.Common;

namespace Урок_19
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }


    }
}
