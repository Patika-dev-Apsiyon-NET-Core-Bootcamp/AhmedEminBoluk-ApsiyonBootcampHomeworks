using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RoleHomeWorkProject
{
    public static class Roles
    {
        public const string HR = "HR";
        public const string IT = "IT";
        public const string Marketing = "Marketing";
        public const string OF = "OF";
        public const string SEC = "SEC";
    }

    public enum ROLES_TYPES : byte
    {
        [Description(Roles.HR)]
        HR = 1,
        [Description(Roles.IT)]
        IT,
        [Description(Roles.Marketing)]
        Marketing,
        [Description(Roles.OF)]
        OF,
        [Description(Roles.SEC)]
        SEC
    }
}
