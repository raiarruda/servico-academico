﻿

namespace Academic.Domain
{
    public class Teacher : User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
